using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
	public class Circle : Shape
	{
		public double Radius { get; set; }
        public Circle(double Radius)
        {
            this.Radius = Radius;   
        }
        public override void area()
		{
			double area = Math.PI * Radius*Radius;
            Console.WriteLine($"Area:{area}");
        }
	}
}
