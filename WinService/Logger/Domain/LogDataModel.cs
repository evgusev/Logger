using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger.Domain
{
	/// <summary>
	/// Contains data about DataSource and logs entry list.
	/// </summary>
	public class LogDataModel
	{
		public LogDataModel()
		{
			Logs = new List<LogDataEntry>();
		}

		/// <summary>
		/// Gets or sets a logs entries.
		/// </summary>
		public IEnumerable<LogDataEntry> Logs { get; set; }

		/// <summary>
		/// Gets or sets a data source type.
		/// </summary>
		public string DataSourceType { get; set; }
	}
}
