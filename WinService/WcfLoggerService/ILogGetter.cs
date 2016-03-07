using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfLoggerService
{
	/// <summary>
	/// Contains get data contracts for logger.
	/// </summary>
	[ServiceContract]
	public interface ILogGetter
	{
		[OperationContract]
		WcfLogData GetLogs();
	}

	/// <summary>
	/// Describes data which would be returned from logger storage.
	/// </summary>
	[DataContract]
	public class WcfLogData
	{
		/// <summary>
		/// Gets or sets a logs entries.
		/// </summary>
		[DataMember]
		public IEnumerable<LogDataEntry> Logs { get; set; }

		/// <summary>
		/// Gets or sets a data source type.
		/// </summary>
		[DataMember]
		public string DataSourceType { get; set; }
	}

	[DataContract]
	public class LogDataEntry
	{
		[DataMember]
		public DateTime CurrentTime { get; set; }
	}
}
