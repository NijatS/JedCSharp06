using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
	public class Rectangle : Shape
	{
		public double Width { get; set; }
		public double Length { get; set; }

		public Rectangle(double width, double length)
		{
			Width = width;
			Length = length;
		}

		public override void area()
		{
			double area = Width * Length;
            Console.WriteLine($"Area:{area}");
        }
	}
}
