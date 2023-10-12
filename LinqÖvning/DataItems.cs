using LinqÖvning.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LinqÖvning
{
	public static class DataItems
	{
		public static List<PersonModel> GetConnectData()
		{
			List<PersonModel> output = new List<PersonModel>();

			output.Add(new PersonModel { Id = 1, FirstName = "Denis", LastName = "Delija", PhoneNumbers = new List<string> { "070-123-456" } });
			output.Add(new PersonModel { Id = 2, FirstName = "Kalle", LastName = "Anka", PhoneNumbers = new List<string> { "070-123-456", "070-123-457" } });
			output.Add(new PersonModel { Id = 3, FirstName = "Musse", LastName = "Pigg", PhoneNumbers = new List<string> { "070-123-456", "070-123-457", "070-123-458" } });
			output.Add(new PersonModel { Id = 4, FirstName = "Kajsa", LastName = "Anka", PhoneNumbers = new List<string> { "070-123-456", "070-123-457", "070-123-459" } });





			return output;



		}

			

		 
	}
}
