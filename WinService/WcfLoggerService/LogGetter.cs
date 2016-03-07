using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Logger.Helpers;
using Logger.Domain;

namespace WcfLoggerService
{
	public class LogGetter : ILogGetter
	{
		public WcfLogData GetLogs()
		{
			var lm = new LogManager();
			var data = lm.GetData();
			return new WcfLogData
			{
 				DataSourceType = data.DataSourceType,
				Logs = data.Logs
					.Select(p => new LogDataEntry
					{
						CurrentTime = p.CurrentTime
					})
					.ToList()
			};
		}
	}
}
