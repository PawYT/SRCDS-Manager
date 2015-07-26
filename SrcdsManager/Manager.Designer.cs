namespace SrcdsManager
{
    partial class Manager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.label1 = new System.Windows.Forms.Label();
			this.startButton = new System.Windows.Forms.Button();
			this.stopButton = new System.Windows.Forms.Button();
			this.newServ = new System.Windows.Forms.Button();
			this.restart = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.settingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.steamCmdToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.startWithWindowsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.updateServerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.installServerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.steamCmdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.runOnStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.updateServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.installServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ServerList = new System.Windows.Forms.DataGridView();
			this.dataGridContext = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.dgContextStart = new System.Windows.Forms.ToolStripMenuItem();
			this.dgContextStop = new System.Windows.Forms.ToolStripMenuItem();
			this.dgContextRestart = new System.Windows.Forms.ToolStripMenuItem();
			this.dgContextUpdate = new System.Windows.Forms.ToolStripMenuItem();
			this.configurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.ServerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgUptime = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgCPU = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgMemory = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgPlayers = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgMap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgIPAddr = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgCrashes = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.ServerList)).BeginInit();
			this.dataGridContext.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
			this.label1.Location = new System.Drawing.Point(9, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 15);
			this.label1.TabIndex = 2;
			this.label1.Text = "Servers:";
			// 
			// startButton
			// 
			this.startButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.startButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
			this.startButton.FlatAppearance.BorderSize = 0;
			this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.startButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.startButton.Image = global::SrcdsManager.Properties.Resources.online_tiny1;
			this.startButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.startButton.Location = new System.Drawing.Point(121, 367);
			this.startButton.Name = "startButton";
			this.startButton.Size = new System.Drawing.Size(60, 23);
			this.startButton.TabIndex = 11;
			this.startButton.Text = "Start";
			this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.startButton.UseVisualStyleBackColor = true;
			this.startButton.Click += new System.EventHandler(this.startButton_Click);
			// 
			// stopButton
			// 
			this.stopButton.FlatAppearance.BorderSize = 0;
			this.stopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.stopButton.Image = global::SrcdsManager.Properties.Resources.offline_tiny;
			this.stopButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.stopButton.Location = new System.Drawing.Point(187, 367);
			this.stopButton.Name = "stopButton";
			this.stopButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.stopButton.Size = new System.Drawing.Size(60, 23);
			this.stopButton.TabIndex = 12;
			this.stopButton.Text = "Stop";
			this.stopButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.stopButton.UseVisualStyleBackColor = true;
			this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
			// 
			// newServ
			// 
			this.newServ.FlatAppearance.BorderSize = 0;
			this.newServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.newServ.Image = global::SrcdsManager.Properties.Resources.plus_tiny;
			this.newServ.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.newServ.Location = new System.Drawing.Point(12, 367);
			this.newServ.Name = "newServ";
			this.newServ.Size = new System.Drawing.Size(103, 23);
			this.newServ.TabIndex = 20;
			this.newServ.Text = "New Server";
			this.newServ.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.newServ.UseVisualStyleBackColor = true;
			this.newServ.Click += new System.EventHandler(this.newServ_Click);
			// 
			// restart
			// 
			this.restart.FlatAppearance.BorderSize = 0;
			this.restart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.restart.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.restart.Image = global::SrcdsManager.Properties.Resources.restart_tiny;
			this.restart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.restart.Location = new System.Drawing.Point(253, 368);
			this.restart.Name = "restart";
			this.restart.Size = new System.Drawing.Size(60, 23);
			this.restart.TabIndex = 26;
			this.restart.Text = "Restart";
			this.restart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.restart.UseVisualStyleBackColor = true;
			this.restart.Click += new System.EventHandler(this.restart_Click);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem1,
            this.toolsToolStripMenuItem1,
            this.aboutToolStripMenuItem1});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(863, 24);
			this.menuStrip1.TabIndex = 27;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// settingsToolStripMenuItem1
			// 
			this.settingsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steamCmdToolStripMenuItem1,
            this.startWithWindowsToolStripMenuItem});
			this.settingsToolStripMenuItem1.Image = global::SrcdsManager.Properties.Resources.settings_gear;
			this.settingsToolStripMenuItem1.Name = "settingsToolStripMenuItem1";
			this.settingsToolStripMenuItem1.Size = new System.Drawing.Size(77, 20);
			this.settingsToolStripMenuItem1.Text = "Settings";
			// 
			// steamCmdToolStripMenuItem1
			// 
			this.steamCmdToolStripMenuItem1.Image = global::SrcdsManager.Properties.Resources.steam;
			this.steamCmdToolStripMenuItem1.Name = "steamCmdToolStripMenuItem1";
			this.steamCmdToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
			this.steamCmdToolStripMenuItem1.Text = "SteamCmd";
			this.steamCmdToolStripMenuItem1.Click += new System.EventHandler(this.steamCmdToolStripMenuItem_Click);
			// 
			// startWithWindowsToolStripMenuItem
			// 
			this.startWithWindowsToolStripMenuItem.Name = "startWithWindowsToolStripMenuItem";
			this.startWithWindowsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.startWithWindowsToolStripMenuItem.Text = "Run on Start";
			this.startWithWindowsToolStripMenuItem.Click += new System.EventHandler(this.runOnStartToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem1
			// 
			this.toolsToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateServerToolStripMenuItem1,
            this.installServerToolStripMenuItem1});
			this.toolsToolStripMenuItem1.Image = global::SrcdsManager.Properties.Resources.settings_wrench;
			this.toolsToolStripMenuItem1.Name = "toolsToolStripMenuItem1";
			this.toolsToolStripMenuItem1.Size = new System.Drawing.Size(64, 20);
			this.toolsToolStripMenuItem1.Text = "Tools";
			// 
			// updateServerToolStripMenuItem1
			// 
			this.updateServerToolStripMenuItem1.Image = global::SrcdsManager.Properties.Resources.updateicon;
			this.updateServerToolStripMenuItem1.Name = "updateServerToolStripMenuItem1";
			this.updateServerToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
			this.updateServerToolStripMenuItem1.Text = "Update Server";
			this.updateServerToolStripMenuItem1.Click += new System.EventHandler(this.updateServerToolStripMenuItem_Click);
			// 
			// installServerToolStripMenuItem1
			// 
			this.installServerToolStripMenuItem1.Image = global::SrcdsManager.Properties.Resources.plus_tiny;
			this.installServerToolStripMenuItem1.Name = "installServerToolStripMenuItem1";
			this.installServerToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
			this.installServerToolStripMenuItem1.Text = "New Server";
			this.installServerToolStripMenuItem1.Click += new System.EventHandler(this.installServerToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem1
			// 
			this.aboutToolStripMenuItem1.Image = global::SrcdsManager.Properties.Resources.infoicon;
			this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
			this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
			this.aboutToolStripMenuItem1.Text = "About";
			this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// settingsToolStripMenuItem
			// 
			this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.steamCmdToolStripMenuItem,
            this.runOnStartToolStripMenuItem});
			this.settingsToolStripMenuItem.Image = global::SrcdsManager.Properties.Resources.settings_gear;
			this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
			this.settingsToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
			this.settingsToolStripMenuItem.Text = "Settings";
			// 
			// steamCmdToolStripMenuItem
			// 
			this.steamCmdToolStripMenuItem.Image = global::SrcdsManager.Properties.Resources.steam;
			this.steamCmdToolStripMenuItem.Name = "steamCmdToolStripMenuItem";
			this.steamCmdToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.steamCmdToolStripMenuItem.Text = "SteamCmd";
			this.steamCmdToolStripMenuItem.Click += new System.EventHandler(this.steamCmdToolStripMenuItem_Click);
			// 
			// runOnStartToolStripMenuItem
			// 
			this.runOnStartToolStripMenuItem.Name = "runOnStartToolStripMenuItem";
			this.runOnStartToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.runOnStartToolStripMenuItem.Text = "Run on Start";
			this.runOnStartToolStripMenuItem.Click += new System.EventHandler(this.runOnStartToolStripMenuItem_Click);
			// 
			// toolsToolStripMenuItem
			// 
			this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateServerToolStripMenuItem,
            this.installServerToolStripMenuItem});
			this.toolsToolStripMenuItem.Image = global::SrcdsManager.Properties.Resources.settings_wrench;
			this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
			this.toolsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
			this.toolsToolStripMenuItem.Text = "Tools";
			// 
			// updateServerToolStripMenuItem
			// 
			this.updateServerToolStripMenuItem.Image = global::SrcdsManager.Properties.Resources.updateicon;
			this.updateServerToolStripMenuItem.Name = "updateServerToolStripMenuItem";
			this.updateServerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.updateServerToolStripMenuItem.Text = "Update Server";
			this.updateServerToolStripMenuItem.Click += new System.EventHandler(this.updateServerToolStripMenuItem_Click);
			// 
			// installServerToolStripMenuItem
			// 
			this.installServerToolStripMenuItem.Image = global::SrcdsManager.Properties.Resources.update_icon;
			this.installServerToolStripMenuItem.Name = "installServerToolStripMenuItem";
			this.installServerToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
			this.installServerToolStripMenuItem.Text = "Install Server";
			this.installServerToolStripMenuItem.Click += new System.EventHandler(this.installServerToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Image = global::SrcdsManager.Properties.Resources.infoicon;
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// ServerList
			// 
			this.ServerList.AllowUserToAddRows = false;
			this.ServerList.AllowUserToDeleteRows = false;
			this.ServerList.AllowUserToResizeColumns = false;
			this.ServerList.AllowUserToResizeRows = false;
			this.ServerList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.ServerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.ServerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
			this.ServerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.ServerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.ServerList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ServerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ServerName,
            this.dgStatus,
            this.dgUptime,
            this.dgCPU,
            this.dgMemory,
            this.dgPlayers,
            this.dgMap,
            this.dgIPAddr,
            this.dgPort,
            this.dgCrashes});
			this.ServerList.Cursor = System.Windows.Forms.Cursors.Arrow;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(70)))), ((int)(((byte)(70)))));
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.ServerList.DefaultCellStyle = dataGridViewCellStyle2;
			this.ServerList.EnableHeadersVisualStyles = false;
			this.ServerList.Location = new System.Drawing.Point(12, 51);
			this.ServerList.MultiSelect = false;
			this.ServerList.Name = "ServerList";
			this.ServerList.ReadOnly = true;
			this.ServerList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
			this.ServerList.RowHeadersVisible = false;
			this.ServerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.ServerList.Size = new System.Drawing.Size(841, 310);
			this.ServerList.TabIndex = 28;
			this.ServerList.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.ServerList_NewRow);
			this.ServerList.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ServerList_Clicked);
			this.ServerList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ServerList_MouseDown);
			// 
			// dataGridContext
			// 
			this.dataGridContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dgContextStart,
            this.dgContextStop,
            this.dgContextRestart,
            this.dgContextUpdate,
            this.configurationToolStripMenuItem});
			this.dataGridContext.Name = "contextMenuStrip1";
			this.dataGridContext.Size = new System.Drawing.Size(149, 114);
			// 
			// dgContextStart
			// 
			this.dgContextStart.Image = global::SrcdsManager.Properties.Resources.online_tiny1;
			this.dgContextStart.Name = "dgContextStart";
			this.dgContextStart.Size = new System.Drawing.Size(148, 22);
			this.dgContextStart.Text = "Start";
			this.dgContextStart.Click += new System.EventHandler(this.dgContextStart_Click);
			// 
			// dgContextStop
			// 
			this.dgContextStop.Image = global::SrcdsManager.Properties.Resources.offline_tiny;
			this.dgContextStop.Name = "dgContextStop";
			this.dgContextStop.Size = new System.Drawing.Size(148, 22);
			this.dgContextStop.Text = "Stop";
			this.dgContextStop.Click += new System.EventHandler(this.dgContextStop_Click);
			// 
			// dgContextRestart
			// 
			this.dgContextRestart.Image = global::SrcdsManager.Properties.Resources.restart;
			this.dgContextRestart.Name = "dgContextRestart";
			this.dgContextRestart.Size = new System.Drawing.Size(148, 22);
			this.dgContextRestart.Text = "Restart";
			this.dgContextRestart.Click += new System.EventHandler(this.dgContextRestart_Click);
			// 
			// dgContextUpdate
			// 
			this.dgContextUpdate.Image = global::SrcdsManager.Properties.Resources.updateicon;
			this.dgContextUpdate.Name = "dgContextUpdate";
			this.dgContextUpdate.Size = new System.Drawing.Size(148, 22);
			this.dgContextUpdate.Text = "Update";
			this.dgContextUpdate.Click += new System.EventHandler(this.dgContextUpdate_Click);
			// 
			// configurationToolStripMenuItem
			// 
			this.configurationToolStripMenuItem.Image = global::SrcdsManager.Properties.Resources.settings_gear;
			this.configurationToolStripMenuItem.Name = "configurationToolStripMenuItem";
			this.configurationToolStripMenuItem.Size = new System.Drawing.Size(148, 22);
			this.configurationToolStripMenuItem.Text = "Configuration";
			this.configurationToolStripMenuItem.Click += new System.EventHandler(this.configurationToolStripMenuItem_Click);
			// 
			// ServerName
			// 
			this.ServerName.HeaderText = "Server Name";
			this.ServerName.Name = "ServerName";
			this.ServerName.ReadOnly = true;
			// 
			// dgStatus
			// 
			this.dgStatus.HeaderText = "Status";
			this.dgStatus.Name = "dgStatus";
			this.dgStatus.ReadOnly = true;
			this.dgStatus.Width = 75;
			// 
			// dgUptime
			// 
			this.dgUptime.HeaderText = "Uptime";
			this.dgUptime.Name = "dgUptime";
			this.dgUptime.ReadOnly = true;
			// 
			// dgCPU
			// 
			this.dgCPU.HeaderText = "CPU";
			this.dgCPU.Name = "dgCPU";
			this.dgCPU.ReadOnly = true;
			this.dgCPU.Width = 50;
			// 
			// dgMemory
			// 
			this.dgMemory.HeaderText = "Memory";
			this.dgMemory.Name = "dgMemory";
			this.dgMemory.ReadOnly = true;
			this.dgMemory.Width = 50;
			// 
			// dgPlayers
			// 
			this.dgPlayers.HeaderText = "Players";
			this.dgPlayers.Name = "dgPlayers";
			this.dgPlayers.ReadOnly = true;
			this.dgPlayers.Width = 75;
			// 
			// dgMap
			// 
			this.dgMap.HeaderText = "Map";
			this.dgMap.Name = "dgMap";
			this.dgMap.ReadOnly = true;
			this.dgMap.Width = 165;
			// 
			// dgIPAddr
			// 
			this.dgIPAddr.HeaderText = "IP Address";
			this.dgIPAddr.Name = "dgIPAddr";
			this.dgIPAddr.ReadOnly = true;
			// 
			// dgPort
			// 
			this.dgPort.HeaderText = "Port";
			this.dgPort.Name = "dgPort";
			this.dgPort.ReadOnly = true;
			this.dgPort.Width = 65;
			// 
			// dgCrashes
			// 
			this.dgCrashes.HeaderText = "Crashes";
			this.dgCrashes.Name = "dgCrashes";
			this.dgCrashes.ReadOnly = true;
			this.dgCrashes.Width = 60;
			// 
			// Manager
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
			this.ClientSize = new System.Drawing.Size(863, 402);
			this.Controls.Add(this.ServerList);
			this.Controls.Add(this.restart);
			this.Controls.Add(this.newServ);
			this.Controls.Add(this.stopButton);
			this.Controls.Add(this.startButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.Cursor = System.Windows.Forms.Cursors.Default;
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Manager";
			this.Text = "SrcdsManager";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ManagerClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.ServerList)).EndInit();
			this.dataGridContext.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button newServ;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem steamCmdToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateServerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem installServerToolStripMenuItem;
        private System.Windows.Forms.DataGridView ServerList;
        private System.Windows.Forms.ContextMenuStrip dataGridContext;
        private System.Windows.Forms.ToolStripMenuItem dgContextStart;
        private System.Windows.Forms.ToolStripMenuItem dgContextStop;
        private System.Windows.Forms.ToolStripMenuItem dgContextRestart;
        private System.Windows.Forms.ToolStripMenuItem dgContextUpdate;
        private System.Windows.Forms.ToolStripMenuItem runOnStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem steamCmdToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem startWithWindowsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem updateServerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem installServerToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
		private System.Windows.Forms.DataGridViewTextBoxColumn ServerName;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgStatus;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgUptime;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgCPU;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgMemory;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgPlayers;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgMap;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgIPAddr;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgPort;
		private System.Windows.Forms.DataGridViewTextBoxColumn dgCrashes;
	}
}

