using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customization
{
	public class Person
	{
		public string Name { get; set; }	
		public string Surname { get; set; }
		public int Age {  get; set; }


        public Person(string Name,string Surname,int Age)
        {
			if (!char.IsUpper(Name[0]) || !char.IsUpper(Surname[0]))
			{
				throw new InvalidObjectName();
			}
			if (Age < 0 || Age > 120)
				throw new InvalidAgeException("O terefde qayb yazillar");
			this.Name = Name;	
			this.Surname = Surname;
			this.Age = Age;
        }
    }
}
