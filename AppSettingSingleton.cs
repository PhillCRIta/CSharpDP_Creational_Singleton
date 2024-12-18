using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Singleton
{
	internal class AppSettingSingleton
	{
		//the instance variable in stored inside the static varibale, not in new the object created
		//the static variable is private, cannot access outside the class
		private static AppSettingSingleton _instance;
		private Dictionary<string, object> _settings = new Dictionary<string, object>();
		private AppSettingSingleton()
		{
			//the private constructor doesn't permit to use NEW keyword
		}
		public static AppSettingSingleton GetInstance()
		{
			//only static method can see the static fields
			if (_instance == null)
			{
				_instance = new AppSettingSingleton();
			}
			return _instance;
		}
		public object Get(string key)
		{
			if (_settings.ContainsKey(key) == false)
			{
				return null;
			}
			else
			{
				return _settings[key];
			}
		}
		public void Set(string key, object value)
		{
			_settings[key] = value;
		}
	}
}
