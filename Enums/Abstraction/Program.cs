using Microsoft.VisualBasic;
using System.Drawing;
using System.Reflection;

namespace Abstraction
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Task 8 : Create a C# program that demonstrates the concept of abstraction. Follow these steps:

			//Create a class called Shape.
			//Define an abstract method within the Shape class called area().
			//Create two subclasses of Shape called Rectangle and Circle.
			//Implement the area() method in both Rectangle and Circle classes to calculate the area of a rectangle and a circle, respectively.
			//Create objects of both Rectangle and Circle classes and call the area() method for each.


			//Circle circle = new Circle(5.5);
			//circle.area();

			//Rectangle rectangle = new Rectangle(4, 5);
			//rectangle.area();



			//Create a class called Vehicle.

			//The Vehicle class should have the following attributes:
			//make: The make of the vehicle.
			//model: The model of the vehicle.
			//year: The year the vehicle was manufactured.

			//Define a method within the class called display_info() that prints out all the information about the vehicle(make, model, and year).

			//Create a class called Car that inherits from the Vehicle class.
			//Add an additional attribute to the Car class:
			//mileage: The current mileage of the car.
			//Override the display_info() method in the Car class to also display the mileage of the car.
			//Create an object of the Car class and display its information.


			Car car = new Car("BMW","530i",2020,10000.5);
			car.display_info();
		}
	}
}
