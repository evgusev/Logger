using Logger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject;
using System.Reflection;

namespace Logger.Helpers
{
	public class LogManager
	{
		private IDataStorage dataStorage;
		private Type storage;
		
		public void WriteData(LogData logData, string dataSourceType)
		{
			var dsl = new DataSourceLoader();
			dsl.SetDataSource(dataSourceType, LoggerApp.Instance.DIContiner);
			
			dataStorage = LoggerApp.Instance.DIContiner.Get<IDataStorage>();
			dataStorage.WriteData(logData);
		}
	}
}
