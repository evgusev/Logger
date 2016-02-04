using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Domain;

namespace DataSource.File
{
	public class FileStorage : IDataStorage
	{
		public IEnumerable<LogData> ReadData()
		{
			return new List<LogData>();
		}

		public void WriteData(LogData logData)
		{
			Console.WriteLine("It works! Time: {0}", logData.CurrentTime.ToString("dd.MM.yy"));
		}
	}
}
