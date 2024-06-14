using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task1
{
	public class Circle : IShape
	{
		public double Radius;
		public Circle(double radius)
		{
			Radius = radius;
		}

		//static Circle()
		//{
		//          Console.WriteLine("Static");
		//      }
		public double GetArea()
		{
			return Math.PI * Math.Pow(Radius, 2);
		}
	}
}
