using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.IO.Ports;
using EnumsNET;

namespace AutoMaster
{
	public static class ConfigInfo
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
			"Custom",
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
		};

        public static ConfigInNvm GetNvmConfig()
        {
            ConfigInNvm configInNvm = new ConfigInNvm();
            configInNvm.showInHex = bool.Parse(ConfigurationManager.AppSettings["showInHex"]);
            configInNvm.autoNewLine = bool.Parse(ConfigurationManager.AppSettings["autoNewLine"]);
            configInNvm.showSend = bool.Parse(ConfigurationManager.AppSettings["showSend"]);
            configInNvm.sendInHex = bool.Parse(ConfigurationManager.AppSettings["sendInHex"]);
            configInNvm.sendNewLine = bool.Parse(ConfigurationManager.AppSettings["sendNewLine"]);
            configInNvm.timeStamp = bool.Parse(ConfigurationManager.AppSettings["timeStamp"]);
            configInNvm.period = int.Parse(ConfigurationManager.AppSettings["period"]);
            configInNvm.baud = int.Parse(ConfigurationManager.AppSettings["baud"]);
            configInNvm.dataBits = int.Parse(ConfigurationManager.AppSettings["dataBits"]);
            string stopBits = ConfigurationManager.AppSettings["stopBits"];
            foreach (var value in Enums.GetMembers<StopBits>())
            {
                if (value.Name.ToString().Equals(stopBits))
                {
                    configInNvm.stopBits = value.Value;
                    break;
                }
            }
            string parity = ConfigurationManager.AppSettings["parity"];
            foreach (var value in Enums.GetMembers<Parity>())
            {
                if (value.Name.ToString().Equals(parity))
                {
                    configInNvm.parity = value.Value;
                    break;
                }
            }
            return configInNvm;
        }

        public static void SaveConfigToNvm(ConfigInNvm config)
        {
            //将用户的输入的配置更新保存到App.config

            Configuration cfa = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            cfa.AppSettings.Settings["showInHex"].Value = config.showInHex.ToString().ToLower();
            cfa.AppSettings.Settings["autoNewLine"].Value = config.autoNewLine.ToString().ToLower();
            cfa.AppSettings.Settings["showSend"].Value = config.showSend.ToString().ToLower();
            cfa.AppSettings.Settings["sendInHex"].Value = config.showInHex.ToString().ToLower();
            cfa.AppSettings.Settings["sendNewLine"].Value = config.sendNewLine.ToString().ToLower();
            cfa.AppSettings.Settings["timeStamp"].Value = config.timeStamp.ToString().ToLower();
            cfa.AppSettings.Settings["period"].Value = config.period.ToString();
            cfa.AppSettings.Settings["baud"].Value = config.baud.ToString();
            cfa.AppSettings.Settings["dataBits"].Value = config.dataBits.ToString();
            cfa.AppSettings.Settings["stopBits"].Value = config.stopBits.ToString();
            cfa.AppSettings.Settings["parity"].Value = config.parity.ToString();
            cfa.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        public class ConfigInNvm
        {
            public bool showInHex;
            public bool autoNewLine;
            public bool showSend;
            public bool sendInHex;
            public bool sendNewLine;
            public bool timeStamp;
            public int period;
            public int baud;
            public int dataBits;
            public StopBits stopBits;
            public Parity parity;
        }
	}
}
