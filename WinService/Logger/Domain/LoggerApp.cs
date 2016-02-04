using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Helpers;
using Ninject;
using System.Reflection;

namespace Logger.Domain
{
	/// <summary>
	/// Contains initial methods for the application.
	/// Implements the singleton.
	/// </summary>
	public class LoggerApp
	{
		private static LoggerApp instance;
		private LoggerApp() {}

		public string DataSourceType { get; private set; }
		public int ReadInterval { get; private set; }
		public StandardKernel DIContiner { get; private set; }

		public static LoggerApp Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new LoggerApp();
				}
				return instance;
			}
		}
		
		/// <summary>
		/// Runs the application.
		/// </summary>
		public void Run()
		{
			DIContiner = new StandardKernel();
			DIContiner.Load(Assembly.GetExecutingAssembly());
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
				Write();
			}
			else
			{
				Write();
			}
		}

		private void Write()
		{
			Config.Refresh();
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
