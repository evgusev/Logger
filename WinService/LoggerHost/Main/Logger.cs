using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LoggerHost.Helpers;

namespace LoggerHost
{
	/// <summary>
	/// Contains initial methods of the application.
	/// </summary>
	public class Logger
	{
		/// <summary>
		/// Runs the application.
		/// </summary>
		public void Run()
		{
			Config.Init();
			bool isFirstRun = true;
			while (true)
			{
				if (isFirstRun)
				{
					isFirstRun = false;
					PerformJob(false);
				}
				PerformJob(true);
			}
		}

		private void PerformJob(bool useDelay)
		{
			if (useDelay)
			{
				System.Threading.Thread.Sleep(Config.ReadInterval);
			}
			Console.WriteLine(Config.DataSource);
		}
	}
}
