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
		public IEnumerable<LogDataEntry> ReadData()
		{
			return new List<LogDataEntry>();
		}

		public void WriteData(LogDataEntry logData)
		{
			Console.WriteLine("It works! Time: {0}", logData.CurrentTime.ToString("dd.MM.yy"));
		}
	}
}
