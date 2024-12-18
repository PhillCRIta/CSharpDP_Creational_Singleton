using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Singleton
{
	internal class TestingConfClass
	{
		public static void Run()
		{
			AppSettingSingleton _settings = AppSettingSingleton.GetInstance();
			Console.WriteLine(_settings.Get("AppName"));
		}
	}
}
