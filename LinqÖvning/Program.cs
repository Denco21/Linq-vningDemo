namespace LinqÖvning
{
	public class Program
	{
		static void Main(string[] args)
		{
			//LambdaExpre();

			QuerySyntax();


			Console.WriteLine("Avslutat arbete");

			Console.ReadLine();

            
        }

		private static void QuerySyntax()
		{
			var persons = DataItems.GetConnectData();

			//var results = (from x in persons
			//			   			       where x.FirstName == "Kalle"
			//							  select x).ToList();

			//foreach (var item in results)

			//{
			//	Console.WriteLine(item.FirstName);
			//}

			var results = (from x in persons
										where x.PhoneNumbers.Count > 2
									    select x).ToList();

			foreach (var item in results)
			{
				Console.WriteLine($"{item.FirstName} {item.LastName}");
			}
		}




		public static void LambdaExpre()
		{
			var data = DataItems.GetConnectData();

			//var results = data.Where(x => x.FirstName == "Kalle").ToList(); 

			//foreach (var item in results)
			//{
			//	Console.WriteLine(item.FirstName);
			//}

			//var results = data.Where(x => x.PhoneNumbers.Count > 2).ToList();  

			//foreach (var item in results)
			//{
   //             Console.WriteLine($"{item.FirstName} {item.LastName}");
   //         }

			//var results = data.Take(2).ToList();

			//foreach (var item in results)
			//{
			//	Console.WriteLine($"{item.FirstName} {item.LastName}");
			//}

			//var results = data.Skip(2).ToList();	

			//foreach (var item in results)
			//{
			//	Console.WriteLine($"{item.FirstName} {item.LastName}");
			//}

			//var results = data.OrderByDescending(x => x.FirstName.Contains('D')).ToList();  

			//foreach (var item in results)
			//{
			//	Console.WriteLine($"{item.FirstName} {item.LastName}");
			//}





		}
	}
}