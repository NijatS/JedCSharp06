using Interfaces.Task1;
using Interfaces.Task2;
using Interfaces.Task3;
using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel;
using System;
using Interfaces.task4;

namespace Interfaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//1)Task: Define an interface IShape with a method GetArea() that returns a double. Implement this interface in a class Circle that has a constructor accepting the radius and calculates the area.

			Circle circle = new Circle(4.5);

			double area = circle.GetArea();

			//Console.WriteLine(area);

			//2)Task: Define an interface IVehicle with a property Speed of type int. Implement this interface in a class Car with a constructor that sets the speed and a method to display the speed.

			Car car = new Car(180);
			int speed = car.GetSpeed();
			//Console.WriteLine(speed);

			//3)Task: Define two interfaces IPrintable with a method Print() and IScannable with a method Scan(). Create a class MultiFunctionPrinter that implements both interfaces.

			MultiFunctionPrinter FP = new MultiFunctionPrinter();
			//FP.Print();
			//FP.Scan();


			//4)Define Parent Interface:

			//Create an interface IMovable with a method Move().

			//Create Derived Interface:

			//Create another interface IVehicle that inherits from IMovable and adds a method StartEngine().
			//Implement Derived Interface:

			//Create a class Car that implements IVehicle.Provide implementations for Move() and StartEngine().
			//Test the Implementation:

			//Write a console application that creates an instance of Car, calls StartEngine(), and then calls Move().
			Masin masin = new Masin();
            //masin.Move();
            //masin.StartEngine();


            #region Math

            // Console.WriteLine(Math.Abs(-6));

            //Console.WriteLine(Math.Min(5,-10));

            //Console.WriteLine(Math.Pow(3,4));

            //Round()

            // Console.WriteLine(Math.Round(5.2));
            //Sqrt()
            //Console.WriteLine(Math.Sqrt(25));
            //Console.WriteLine(Math.Pow(27,(double)1/3));
            //Ceiling()
            //Console.WriteLine(Math.Ceiling(5.8));
            //Console.WriteLine(Math.Floor(5.7));
            #endregion
        }
	}
}
