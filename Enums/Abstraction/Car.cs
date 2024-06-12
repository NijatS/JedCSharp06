using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
	public class Car : Vehicle
	{
		public double Mileage {  get; set; }
		public Car(string Make,string Model,int Year,double Mileage):base(Make,Model,Year)
		{
			this.Mileage = Mileage;
		}
		public override void display_info()
		{
			base.display_info();
            Console.WriteLine($"   Mileage:{Mileage}");
        }
	}
}
