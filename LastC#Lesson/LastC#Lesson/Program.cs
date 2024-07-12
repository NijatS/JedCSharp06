using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System;
using System.Globalization;
using System.Numerics;

namespace LastC_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //*Action to print a message:

            Action<string> action1 = delegate (string name)
            {
                Console.WriteLine(name + " Welcome to my channel");
            };

            //action1("Yusif");

            //*Delegate to concatenate two strings:

            Func<string, string, string> func1 = (s1, s2) => string.Concat(s1, s2);

            //Console.WriteLine(func1("Salam,","bugun necesen?"));


            //*Func to find the maximum of two numbers:

            Func<int, int, int> func2 = (number1, number2) =>
            {
                if (number1 > number2)
                    return number1;
                return number2;
            };

            //Console.WriteLine(func2(2,4));


            //*Predicate to check if a string is null or empty:


            //Predicate<string> pred1 = (s) => string.IsNullOrEmpty(s);

            //*Predicate to check if a number is prime:

            Predicate<int> pred2 = (number) =>
            {
                if (number == 1)
                    return false;

                for (int i = 2; i < number; i++)
                    if (number % i == 0)
                        return false;

                return true;
            };

            //Console.WriteLine(pred2(4));

            //*Func to check if a list contains a specific element:

            Func<List<string>, string, bool> func3 = (list, text) =>
            {
                foreach (string item in list)
                    if (item == text)
                        return true;

                return false;
            };
            //Console.WriteLine(func3(["Azima","Nijat","Yusif"],"Azima"));

            //*Delegate to calculate the distance between two points:


            Func<(double, double), (double, double), double> func4 = (cor1, cor2) => Math.Sqrt(Math.Pow(cor1.Item1 - cor2.Item1, 2) + Math.Pow(cor1.Item2 - cor2.Item2, 2));


           // Console.WriteLine(func4((3, 4), (6, 8)));

            //*Action to log a message to a file:

            Action<string, string> act2 = (path, message) =>
            {
                if (!File.Exists(path))
                {
                    var st =  File.Open(path, FileMode.Create);
                    st.Close();
                }

                File.AppendAllText(path, message);
            };


            act2(@"C:\Users\Nijat\OneDrive\Desktop\C#06\LastC#Lesson\LastC#Lesson\test2.txt", "Salammm");

            //*Delegate to find the median of an array of numbers:

            Func<int[], double> func5 = (array) =>
            {
                Array.Sort(array);
                int length = array.Length;

                return length % 2 == 0 ? (double)(array[length / 2 - 1] + array[length / 2]) / 2 : array[length / 2];
            };

            //Console.WriteLine(func5([2,5,1,6,1,8,3,4]));

            //*Predicate to check if a list of integers is sorted:

            Predicate<List<int>> pred3 = (list) =>
            {
                for (int i = 0; i < list.Count-1; i++)
                {
                    if (list[i] > list[i + 1])
                        return false;
                }
                return true;
            };

            //Console.WriteLine(pred3([1,2,5,6,8,9]));


            //*Func to create a dictionary from two lists (keys and values):List<string>, List<int>

            Func<List<string>, List<int>, Dictionary<string, int>> func6 = (keys, values) =>
            {
                Dictionary<string, int> dict = new();

                if (keys.Count != values.Count)
                    return null;

                for (int i = 0;i < keys.Count; i++)
                {
                    dict[keys[i]] = values[i];  
                }
                return dict;
            };
            Dictionary<string, int> newDict = func6(["Azima", "Yusif", "Nijat"], [0, 5, -5]);

            foreach (KeyValuePair<string,int> pairs in newDict)
            {
                Console.WriteLine($"Key:{pairs.Key}  Value:{pairs.Value}");
            }
            //* Delegate to compute the dot product of two vectors:


            Func<Vector2, Vector2, float> func7 = (vec1,vec2) => vec1.X * vec2.X + vec1.Y * vec2.Y;

            // Console.WriteLine(func7(new(1,4),new(5,3)));


            Thread t1 = new Thread(() =>
            {
                searchFiles("e");
            });
            Thread t2 = new Thread(() =>
            {
                searchFiles("e");
            });
            Thread t3 = new Thread(() =>
            {
                searchFiles("e");
            });

            t1.Start();
            t2.Start();
            t3.Start();

        }
        public static void searchFiles(string fileName)
        {
            DirectoryInfo dir = new DirectoryInfo(@"C:\Users\Nijat\OneDrive\Desktop\Tasks");
            FileInfo[] files = dir.GetFiles();

            foreach (FileInfo file in files)
            {
                if (file.Name.Contains(fileName))
                {
                    Console.WriteLine(file.Name + " " + Thread.CurrentThread.ManagedThreadId);
                    break;
                }
            }
        }
    }
}
