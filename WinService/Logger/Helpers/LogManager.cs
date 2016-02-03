using Logger.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Helpers
{
	public class LogManager
	{
		private IDataStorage dataStorage;

		public void WriteData(LogData logData, string dataSourceType)
		{
			//set data source
			dataStorage.WriteData(logData);
		}
	}
}
