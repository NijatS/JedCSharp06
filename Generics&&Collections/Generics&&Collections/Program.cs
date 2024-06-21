using System.Collections;
using System.Numerics;
using System.Xml.Linq;

namespace Generics__Collections
{
	internal class Program
	{
		static void Main(string[] args)
		{

			//ClassTest<int> classTest = new ClassTest<int>();
			//classTest.Property = 1;


			//ClassTest<string> classTest1 = new ClassTest<string>();
			//classTest1.Property = "sadasd";


			//DataGenericStore<int> dataIntStore = new DataGenericStore<int>();
			//dataIntStore.Data = 5;


			//DataGenericStore<string> dataStringStore = new DataGenericStore<string>();
			//dataStringStore.Data = "Nijat";


			//DataGenericStore<char> dataCharStore = new DataGenericStore<char>();
			//dataCharStore.Data = 'a';

			//DataGenericStore<Person> dataPersonStore = new DataGenericStore<Person>();

			//dataPersonStore.Data = new Person()
			//{
			//	Id = 1,
			//	Name="Yusif"
			//};
			//DataGenericStore<Teacher> dataTeacherStore = new DataGenericStore<Teacher>();


			//1)Generic Swap Method

			//Write a generic method that swaps two elements .

			//2)Generic Max Method

			//Write a generic method to find the maximum of two values.



			//3)Generic Print Method

			//Write a generic method that prints all elements in an array.

			//int num1 = Convert.ToInt32(Console.ReadLine());	
			//int num2 = int.Parse(Console.ReadLine());

			//Console.WriteLine(SwapElements<int>(num1, num2));
			//Console.WriteLine(MaxValues<int>(num1,num2));

			//int[] numbers = [1, 2, 3, 4];
			//PrintArray(numbers);

			ArrayList arrayList = new ArrayList();
			arrayList.Add("Salam");
			arrayList.Add(1);

			string[] names = ["a", "b", "c", "d"];
			PrintArray(names);

        }


		static void PrintArray<T>(T[] array)
		{
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

		

		static (T, T) SwapElements<T>(T item1,T item2)
		{
			T temp = item1;
			item1 = item2;
			item2 = temp;

			return (item1, item2);
		}
		static T MaxValues<T>(T item1, T item2) where T : IBinaryInteger<T>
		{
		
			if (item1 > item2)
				return item1;
			return item2;
		}


		//


		
	}
}
