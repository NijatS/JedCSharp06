using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
	public class Vehicle
	{
		public string Make {  get; set; }
		public string Model { get; set; }
		public int Year { get; set; }

        public Vehicle(string Make,string Model,int Year)
        {
            this.Make = Make;
			this.Model = Model;
			this.Year = Year;
        }

        public virtual void display_info()
		{
            Console.Write($"Make:{Make}  Model:{Model}  Year:{Year}");
        }
	}
}
