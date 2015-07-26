using System;
using System.Threading;
using System.Diagnostics;
using System.Net;
using System.Net.Sockets;
using QueryMaster;

namespace SrcdsManager
{
    class SrcdsMonitor : IDisposable
    {
        public SrcdsStatus Status = SrcdsStatus.Offline;
        public bool isAutoStart = false;
        public String AffinityMask = new String('1', Environment.ProcessorCount);

        private String exePath;
        private String commandLine;
        private String Name;
        private String sID;
        private String game;
		private String map = "";
        private IPAddress ipAddr;
		private int maxplayers;
		private int players;
		private int bots;
        private int port;
        private Manager caller;
        private bool running = false;
        private bool cleanExit = true;
        private Process proc = new Process();
        private ProcessStartInfo startInfo;
        private int crashes = 0;
        private DateTime startTime;
        private SrcdsPinger pinger;
        private Thread oThread;

        public SrcdsMonitor(String exePath, String game, String commandLine, String Name, String sID, String ipAddr, String port, String maxplayers, String AffinityMask, object caller)
        {
			this.exePath = exePath;
            this.commandLine = commandLine;
            this.Name = Name;
            this.sID = sID;
            this.game = game;
            this.AffinityMask = AffinityMask;

            startInfo = new ProcessStartInfo();
            startInfo.FileName = exePath;
			
            if (ipAddr == "0.0.0.0")
            {
                IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (IPAddress addr in host.AddressList)
                {
                    if (addr.AddressFamily == AddressFamily.InterNetwork)
                    {
                        this.ipAddr = addr;
                        break;
                    }
                }
            }
            else
            {
                this.ipAddr = IPAddress.Parse(ipAddr);
            }

            this.port = int.Parse(port);
			this.maxplayers = int.Parse(maxplayers);

            proc.StartInfo = startInfo;

            this.caller = (Manager)caller;

            pinger = new SrcdsPinger(this, this.ipAddr, this.port, proc);
        }

        public void Start()
        {
            startInfo.Arguments = String.Format("-game {0} -console -ip {1} -port {2} -maxplayers_override {3}", game, ipAddr, port, maxplayers) + " " + commandLine;
			
            char[] temp = AffinityMask.ToCharArray();
            Array.Reverse(temp);
            
            try
            {
                proc.Start();
                proc.ProcessorAffinity = new IntPtr(Convert.ToInt32(new String(temp), 2));
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(System.ComponentModel.Win32Exception))
                {
                    caller.ErrorBox(1);
                    return;
				}
				else
				{
					throw;
				}
			}

            pinger.StartChecking();

            WaitForExit oWait = new WaitForExit(proc, this, 0);
            oThread = new Thread(new ThreadStart(oWait.Waiting));
            oThread.Start();

            running = true;
            this.Status = SrcdsStatus.Online;
            cleanExit = false;

            startTime = DateTime.Now;
        }
        public void Crashed()
        {
            this.crashes++;

            proc.Dispose();
            proc = new Process();
            proc.StartInfo = startInfo;


            try
            {
                this.Start();
            }
            catch (Exception ex)
            {
                if (ex.GetType() == typeof(System.InvalidOperationException))
                {
                    caller.ErrorBox(1);
                    return;
				}
				else
				{
					throw;
				}
			}

            startTime = DateTime.Now;
            this.Status = SrcdsStatus.Online;
        }
        public void Stop()
        {
            cleanExit = true;
            pinger.Dispose();
            proc.Kill();

            running = false;
            this.Status = SrcdsStatus.Offline;
        }

        public void Exited(object caller)
        {
            caller = null;
            if (cleanExit != true)
            {
                pinger.Dispose();
                Crashed();
            }
        }

        public void WaitForUpdate(Process proc)
        {
            this.Status = SrcdsStatus.Updating;
            WaitForExit oWait = new WaitForExit(proc, this, 1);
            Thread wThread = new Thread(new ThreadStart(oWait.Waiting));
            wThread.Start();
        }

        public void DoneUpdating()
        {
            this.Status = SrcdsStatus.Offline;
        }

        public void WaitForInstall(Process proc)
        {
            this.Status = SrcdsStatus.Installing;
            WaitForExit oWait = new WaitForExit(proc, this, 2);
            Thread wThread = new Thread(new ThreadStart(oWait.Waiting));
            wThread.Start();
        }

        public void DoneInstalling()
        {
            this.Status = SrcdsStatus.Offline;
        }

        public String getCmd()
        {
            return commandLine;
        }

        public void setCmd(String commandLine)
        {
            this.commandLine = commandLine;

            startInfo.Arguments = commandLine;
        }

        public String getExe()
        {
            return exePath;
        }

        public void setExe(String exePath)
        {
            this.exePath = exePath;

            startInfo.FileName = exePath;
        }

        public String getAddr()
        {
            return ipAddr.ToString();
        }

        public void setIPAddr(String ipAddr)
        {
            this.ipAddr = IPAddress.Parse(ipAddr);
        }

		public String getCPU()
		{
			try { return GetPIDCpuUsage(proc.Id); }
			catch (Exception) { return "N/A"; }
		}

		private static string GetPIDCpuUsage(int pid)
		{
			PerformanceCounterCategory cat = new PerformanceCounterCategory("Process");

			string[] instances = cat.GetInstanceNames();
			foreach (string instance in instances)
			{
				using (PerformanceCounter cnt = new PerformanceCounter("Process",
					 "ID Process", instance, true))
				{
					int val = (int)cnt.RawValue;
					if (val == pid)
					{
						var cpuCounter = new PerformanceCounter("Process", "% Processor Time", instance);
						return cpuCounter.NextValue().ToString() + "%";
					}
				}
			}
			throw new Exception("Something went wrong!");
		}

		private static string GetPIDMemUsage(int pid)
		{
			PerformanceCounterCategory cat = new PerformanceCounterCategory("Process");

			string[] instances = cat.GetInstanceNames();
			foreach (string instance in instances)
			{
				using (PerformanceCounter cnt = new PerformanceCounter("Process",
					 "ID Process", instance, true))
				{
					int val = (int)cnt.RawValue;
					if (val == pid)
					{
						var cpuCounter = new PerformanceCounter("Process", "Working Set - Private", instance);
						int memsize = Convert.ToInt32(cpuCounter.NextValue()) / (int)(1048576);
						return memsize.ToString() + " MB";
					}
				}
			}
			throw new Exception("Something went wrong!");
		}

		public String getMemory()
		{
			try { return GetPIDMemUsage(proc.Id); }
			catch (Exception) { return "N/A"; }
		}

		public String getMaxplayers(bool raw)
		{
			if (raw)
				return maxplayers.ToString();
			else
				return (players).ToString() + "/" + maxplayers.ToString() + " (" + bots.ToString() + " bots)";
		}

		public String getMap()
		{
			return map.ToString();
		}

		public String getPort()
        {
            return port.ToString();
        }

		public void setPort(String port)
		{
			this.port = int.Parse(port);
		}

		public void setMap(String map)
		{
			this.map = map;
		}

		public void setPlayers(String players)
		{
			this.players = int.Parse(players);
		}

		public void setBots(String bots)
		{
			this.bots = int.Parse(bots);
        }

		public String getName()
        {
            return Name;
        }

        public void setName(String Name)
        {
            this.Name = Name;
        }

        public String getId()
        {
            return sID;
        }

        public bool isRunning()
        {
            return running;
        }

        public String getUptime()
        {
            if (this.isRunning())
            {
                TimeSpan time = DateTime.Now - startTime;
                return String.Format("{0:00}:{1:00}:{2:00}", Math.Floor(time.TotalHours), time.Minutes, time.Seconds);
            }
            else
            {
                return "00:00:00";
            }
        }
        public String getCrashes()
        {
            return crashes.ToString();
        }
        public void Dispose()
        {
            proc.Dispose();
            pinger.Dispose();
        }
    }

    class WaitForExit
    {
        private Process proc;
        private SrcdsMonitor caller;
        private int procType;

        public WaitForExit(Process proc, object caller, int procType)
        {
            this.proc = proc;
            this.caller = (SrcdsMonitor)caller;
            this.procType = procType;
        }
        public void Waiting()
        {
            proc.WaitForExit();
            switch (procType)
            {
                case 0:
                    caller.Exited(this);
                    return;
                case 1:
                    caller.DoneUpdating();
                    return;
                case 2:
                    caller.DoneInstalling();
                    return;
            }
        }
    }

    class SrcdsPinger : IDisposable
    {
        private System.Timers.Timer checkTimer;
        private int timeouts = 0;
        private SrcdsMonitor caller;
        private Process proc;

        public SrcdsPinger(object source, IPAddress addr, int port, Process proc)
        {
            this.caller = (SrcdsMonitor)source;
            this.proc = proc;
        }
        public void StartChecking()
        {
            checkTimer = new System.Timers.Timer(10000);
			checkTimer.SynchronizingObject = null;
			checkTimer.Elapsed += new System.Timers.ElapsedEventHandler(CheckServer);
			checkTimer.AutoReset = true;
			checkTimer.Enabled = true;
			checkTimer.Start();
        }

		private void CheckServer(object source, System.Timers.ElapsedEventArgs e)
		{			
			try
			{
				using (Server server = ServerQuery.GetServerInstance(EngineType.Source, caller.getAddr(), ushort.Parse(caller.getPort()), null))
				{
					var serverInfo = server.GetInfo();
					caller.setMap(serverInfo.Map);
					caller.setPlayers(serverInfo.Players.ToString());
					caller.setBots(serverInfo.Bots.ToString());
				}
				caller.Status = SrcdsStatus.Online;
			}
			catch (ObjectDisposedException) { this.Dispose(); }
			catch (Exception)
			{
				timeouts++;
				caller.Status = SrcdsStatus.NoReply;

				if (timeouts > 3)
				{
					timeouts = 0;
                    caller.setMap("N/A");
					caller.setPlayers("-1");
					caller.setBots("0");
					caller.Status = SrcdsStatus.Timedout;
					proc.Kill();
				}
			}
		}
        public void Dispose()
        {
            try
            {
				checkTimer.Dispose();
            }
            catch (Exception ex)
            {
                if (ex.GetType() != typeof(NullReferenceException))
                {
                    throw;
                }
            }
        }
    }
}