using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Creational_Singleton
{
	internal class AppSettingsBAD
	{
		private Dictionary<string, object> _settings = new Dictionary<string, object>();
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
