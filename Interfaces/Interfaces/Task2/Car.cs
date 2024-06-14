using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces.Task2
{
	internal class Car : IVehicle
	{
		public int Speed { get; set; }
		public Car(int speed)
		{
			this.Speed = speed;
		}
		public int GetSpeed() => this.Speed;
		
	}
}
