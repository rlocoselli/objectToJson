using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectToJson
{
	class Program
	{
		static void Main(string[] args)
		{
			Contact contact = new Contact()
			{
				Address = "12nd Street",
				Name = "John Doe da Silva"
			};

			Console.WriteLine(ObjectToJson.convertObjectToJson(contact));
			Console.WriteLine("Press any key to continue");
			Console.Read();
		}
	}
}
