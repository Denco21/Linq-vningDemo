﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqÖvning.Models
{
	public class PersonModel
	{
        public int Id { get; set; }
        public string  FirstName { get; set; }

        public string LastName { get; set; }    

        public List<string> PhoneNumbers { get; set; } = new List<string>();


    }
}
