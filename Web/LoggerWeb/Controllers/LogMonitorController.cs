using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LoggerWeb.Helpers;

namespace LoggerWeb.Controllers
{
	public class LogMonitorController : Controller
	{
		//
		// GET: /LogMonitor/
		private LogMonitorManager lmm = new LogMonitorManager();

		public ActionResult Index()
		{
			var model = lmm.GetLogData();
			return View(model);
		}

	}
}
