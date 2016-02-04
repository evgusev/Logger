using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using Logger.Domain;
using System.Runtime.Remoting;
using Ninject;
using System.IO;
using System.Windows.Forms;

namespace Logger.Helpers
{
	/// <summary>
	/// Contains methods for switch data source actions.
	/// </summary>
	public class DataSourceLoader
	{
		/// <summary>
		/// Set new data source and apply binding for the data source interface.
		/// </summary>
		public void SetDataSource(string sourceType, StandardKernel ninjectKernel)
		{
			var storageType = TryToLoadDll(sourceType);
			var type = storageType;

			var currentObj = ninjectKernel.TryGet<IDataStorage>();
			if (currentObj == null || currentObj.GetType() != type)
			{
				ninjectKernel.Bind<IDataStorage>().To(type);
			}
		}

		private static Type TryToLoadDll(string sourceType)
		{
			dynamic result = null;
			var appPath = Path.GetDirectoryName(Application.ExecutablePath);
			var dll = Assembly.LoadFile(string.Concat(appPath, "\\", Config.DataSourceDllPrefix, sourceType, ".dll"));
			
			foreach(Type type in dll.GetExportedTypes())
			{
				result = type;
			}
			return result;
			
		}
	}
}
