using System;
using System.Runtime.InteropServices;

namespace SrcdsManager
{
	class NativeMethods
	{
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();
	}
}
