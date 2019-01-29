using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ObjectToJson
{
	public class ObjectToJson
	{
		public static string convertObjectToJson(object obj)
		{
			var json = JsonConvert.SerializeObject(obj);

			return json;
		}
	}
}
