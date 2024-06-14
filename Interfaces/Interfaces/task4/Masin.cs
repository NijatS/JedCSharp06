using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.task4
{

	internal class Masin : IVehicle
	{
		public void Move()
		{
            Console.WriteLine("Move metodu");
        }

		public void StartEngine()
		{
            Console.WriteLine("Start Engine metodu");
        }
	}
}
