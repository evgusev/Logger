using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Helpers;

namespace Logger.Domain
{
	/// <summary>
	/// Contains initial methods for the application.
	/// Implements the singleton.
	/// </summary>
	public class Logger
	{
		private static Logger instance;
		private Logger() {}

		public string DataSourceType { get; private set; }
		public int ReadInterval { get; private set; }

		public static Logger Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new Logger();
				}
				return instance;
			}
		}
		
		/// <summary>
		/// Runs the application.
		/// </summary>
		public void Run()
		{
			bool isFirstRun = true;
			while (true)
			{
				if (isFirstRun)
				{
					isFirstRun = false;
					PerformJob(false);
				}
				else
				{
					PerformJob(true);
				}
			}
		}

		private void PerformJob(bool useDelay)
		{
			Config.Refresh();
			FillTheProperties();
			WriteData(useDelay);
		}

		private void FillTheProperties()
		{
			DataSourceType = Config.DataSource;
			ReadInterval = Config.ReadInterval;
		}

		private void WriteData(bool useDelay)
		{
			if (useDelay)
			{
				System.Threading.Thread.Sleep(Config.WriteInterval);
				var logData = new LogData
				{
					CurrentTime = DateTime.Now
				};
				var logManager = new LogManager();
				logManager.WriteData(logData, DataSourceType);
				Console.WriteLine("Data has been written into {0}", DataSourceType);
			}
		}
	}
}
