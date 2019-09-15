using System;
using System.IO;
using System.Runtime.InteropServices;

namespace fnalibs
{
	public static class FNALibs
	{
		[DllImport("kernel32.dll", CharSet = CharSet.Unicode, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		private static extern bool SetDllDirectory(string lpPathName);

		public static void Init()
		{
			// https://github.com/FNA-XNA/FNA/wiki/4:-FNA-and-Windows-API#64-bit-support
			if (Environment.OSVersion.Platform == PlatformID.Win32NT)
			{
				SetDllDirectory(Path.Combine(
					AppDomain.CurrentDomain.BaseDirectory,
					Environment.Is64BitProcess ? "x64" : "x86"
				));
			}
		}
	}
}
