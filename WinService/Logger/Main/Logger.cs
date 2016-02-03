using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Helpers;

namespace Logger
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
			if (useDelay)
			{
				System.Threading.Thread.Sleep(Config.ReadInterval);
			}
			Console.WriteLine(Config.DataSource);
		}
	}
}
