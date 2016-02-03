using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Configuration;

namespace LoggerHost.Helpers
{
	public static class Config
	{
		/// <summary>
		/// Gets a type of the data layer.
		/// </summary>
		public static string DataSource { get; private set; }

		/// <summary>
		/// Gets a interval for checking data layer type from config.
		/// In Milliseconds.
		/// </summary>
		public static int ReadInterval { get; private set; }

		/// <summary>
		/// Gets a interval for writing data into data storage.
		/// In Milliseconds.
		/// </summary>
		public static int WriteInterval { get; private set; }

		/// <summary>
		/// Initialize config settings.
		/// </summary>
		public static void Init()
		{
			DataSource = ReadConfigParam("DataSource", "File");
			ReadInterval = ReadConfigParam("ReadInterval", 10000);
			WriteInterval = ReadConfigParam("WriteInterval", 5000);
		}

		private static T ReadConfigParam<T>(string name, T defaultValue)
		{
			string value = ConfigurationManager.AppSettings[name];
			if (string.IsNullOrEmpty(value))
			{
				return defaultValue;
			}
			else
			{
				return (T)Convert.ChangeType(value, typeof(T));
			}
		}
	}
}
