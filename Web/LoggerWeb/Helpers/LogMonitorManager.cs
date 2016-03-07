using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WcfLoggerService;

namespace LoggerWeb.Helpers
{
	public class LogMonitorManager
	{
		public WcfLogData GetLogData()
		{
			var serciveLogGetter = new LogGetter();
			return serciveLogGetter.GetLogs();
		}
	}
}