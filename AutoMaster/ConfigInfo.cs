using System;
using System.Collections.Generic;
using System.Text;

namespace AutoMaster
{
	class ConfigInfo
	{
		public enum Enable
		{
			Disable = 0,
			Enable = 1,
		}
		public enum Protocols
		{
			Normal = 0,
			Xmodem = 1,
		}
        
        public static int[] DataBits = 
        {5, 6, 7, 8};

        public static string[] Bauds= 
		{
			"1200",
			"2400",
			"4800",
			"9600",
			"19200",
			"38400",
			"43000",
			"56000",
			"57600", 
			"115200",
			//"Custom",
		};

	}
}
