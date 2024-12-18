using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Singleton
{
	internal class TestingConfClassBAD
	{
		public static void Run()
		{
			AppSettingsBAD _settings = new AppSettingsBAD();
			Console.WriteLine(_settings.Get("AppName"));
		}
	}
}
