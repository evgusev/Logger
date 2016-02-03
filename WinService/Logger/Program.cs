using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logger.Domain;

namespace Logger
{
	class Program
	{
		static void Main(string[] args)
		{
			var app = Domain.Logger.Instance;
			app.Run();
		}
	}
}
