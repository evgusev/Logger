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
			var ninjectKernel = new StandardKernel();
			dsl.SetDataSource(dataSourceType, ninjectKernel);
			
			dataStorage = ninjectKernel.Get<IDataStorage>();
			dataStorage.WriteData(logData);
		}
	}
}
