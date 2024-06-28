using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text.Unicode;
using System.Threading;

namespace Null__NullAble
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string a = "Azima";
            string b = null;


            int c = default(int);

            //int c;
            //a = a + c;

            //Eger value type-i reference type daxilinde isletsek,yeniki int type class daxilinde olarsa , o zaman int type-in default deyeri 0 olacaq

            Book book = new Book()
            {
                Author = "Nijat",
                Description = "dassdasdasdasdasd",
                Id = Guid.NewGuid(),
                Name = "Jet Sevgi",
            };

            //Console.WriteLine(book.Author);

            Book book2 = new Book();

            //Console.WriteLine(book2.Price);

            Book book3 = null;
            //Console.WriteLine(book3.Author);
            //Console.WriteLine(book3.Price);


            //int number = null;

            //*Write a method that takes a string as an input and checks if it is null or empty.If the string is null or empty, return "Input is null or empty." Otherwise, return the string in uppercase.


            //var result =  CheckString("null");
            // Console.WriteLine(result);


            // int? number2 = 5;
            // Console.WriteLine(number2);

            List<Book> books = new List<Book>()
            {
                new Book()
                {
                    Name = "Test1"
                },
                 new Book()
                {
                    Name = "Test2"
                },
                  new Book()
                {
                    Name = "Test3"
                },
                   new Book()
                {
                    Name = "Test4"
                },
                    new Book()
                {
                    Name = "Test5"
                },
            };

            //Console.WriteLine(findedBook?.Name);

            //if(findedBook == null)
            //    Console.WriteLine("Null object tapildi :)");

            //if (findedBook is null)
            //    Console.WriteLine("Null object tapildi :)");

            //if (findedBook is not { })
            //    Console.WriteLine("Null object tapildi :)");


            //if (ReferenceEquals(findedBook,null))
            //    Console.WriteLine("Null object tapildi :)");

            //string message;

            //if (findedBook is null)
            //{
            //    message = "Nulldir";
            //}
            //else
            //{
            //    message = "Obyektimiz null deyil";
            //}

            //Console.WriteLine(message);

            Book? findedBook = FindBook("Test1", books);


            string message = findedBook?.Name ?? "Obyektimiz nulldir";

            //Console.WriteLine(message);

            //Console.WriteLine(SumInts(null, 5));

            //Console.WriteLine(EarlierDate(new DateTime(2024, 6, 29), new DateTime(2024, 6, 28)));

            //Console.WriteLine(RectangleArea(5,null));

            Dictionary<string, int?> dic = new Dictionary<string, int?>();
            dic.Add("Test1", null);
            dic.Add("Test2", 2);
            dic.Add("Test3", null);
            dic.Add("Test4", 3);
            dic.Add("Test5", null);

            Dictionary<string, int?> newDic = ModifiedDic(dic);

            foreach (var item in newDic)
            {
                Console.WriteLine("Key:"+ item.Key + " Value:" + item.Value);
            }
            //Console.WriteLine(1&0);
        }
        public static Book? FindBook(string name, List<Book> books)
        {
            foreach (Book book in books)
            {
                if (book.Name == name)
                {
                    return book;
                }
            }
            return null;
        }
        //*Write a method that takes a string as an input and checks if it is null or empty.If the string is null or empty, return "Input is null or empty." Otherwise, return the string in uppercase.
        public static string CheckString(string text)
        {
            if (String.IsNullOrEmpty(text))
                return "Input is null or empty";

            return text.ToUpper();
        }
        //*Write a method that takes two nullable integers and returns their sum.If either integer is null, treat it as zero.
        public static int SumInts(int? num1,int? num2)
        {
            if (!num1.HasValue)
                num1 = 0;
            if (!num2.HasValue) 
                num2 = 0;


            return num1.Value + num2.Value;
        }

        //*Write a method that takes two nullable DateTime objects and returns the earlier of the two.If both are null, return null. If one is null, return the other.

        public static DateTime? EarlierDate(DateTime? date1,DateTime? date2)
        {
            if (date1 is null && date2 is null)
                return null;
            else if (date1 is null)
                return date2;
            else if(date2 is null)
                return date1;

            if (date1 < date2)
                return date1;
            else
                return date2;
        }

       //*Write a method that calculates the area of a rectangle.The method should take two nullable double parameters for the width and height. If either parameter is null, use a default value of 1.0.

        public static double RectangleArea(double? side1,double? side2)
        {
            if (!side1.HasValue)
                side1 = 1.0;

            if(!side2.HasValue)
                side2 = 1.0;

            return side1.Value * side2.Value;
        }

        //*Write a method that takes a dictionary of string keys and nullable integer values.If a value is null, set it to the specified default value using the null-coalescing assignment operator (??=). Return the modified dictionary.

        public  static Dictionary<string,int?> ModifiedDic(Dictionary<string,int?> dic)
        {
            foreach(var kv in dic)
            {
                //if (kv.Value is null)
                //    dic[kv.Key] = 0;

                dic[kv.Key] ??= 0;
            }
            return dic;
        }

    }
}
