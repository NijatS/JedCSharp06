using System.Xml.Linq;

namespace AnonymousFunctions
{
    internal class Program
    {
        delegate int MathOperationHandler(int num1, int num2);
        static void Main(string[] args)
        {
            //MathOperationHandler handler = Sum;
            //var result = handler(5, 10);
            //Console.WriteLine(result);

            //handler = Subtract;
            //Console.WriteLine(handler(10, 5));


            //var SumLambda = (int num1, int num2) =>
            //{
            //    return num1 + num2;
            //};//Lambda functions

            //var SubtracLambda = (int num1, int num2) =>
            //{
            //    return num1 - num2;
            //};
            //Func<int, int, int> hand = (num1, num2) =>num1 + num2; //Anonymous Function
            //Console.WriteLine(hand.Invoke(2, 4));

            //MathOperationHandler handler = (num1, num2) => num1 * num2;


            //HandleMathDelegate(handler, 2, 5);

            //Given an array of integers { 23, 4, 8, 11, 6, 57, 18, 9}, find the integers that are greater than 10.With normal C#, you would use a foreach loop and if statement for solving this problem. However instead you can use LINQ. Let’s see the solution with three ways (foreach, expression & API):


            //int[] numbers = { 23, 4, 8, 11, 6, 57, 18, 9 };
            //List<int> greater = new();

            //foreach (var number in numbers)
            //{
            //    if (number > 10)
            //    {
            //        greater.Add(number);
            //    }
            //}

            //Query expression

            //var queryGreaterList = (from number in numbers
            //                        where number > 10
            //                        select number).ToList();

            //IEnumerable
            //IQueryable


            //foreach (var number in queryGreaterList)
            //{
            //    Console.WriteLine(number);
            //}
            //Console.WriteLine("----------------------------------");
            ////LINQ API

            //var linqGreaterList = numbers.Where(number => number > 10).ToList();

            //foreach (var number in linqGreaterList)
            //{
            //    Console.WriteLine(number);
            //}


            //Given an array of integers {23, 4, 8, 4,23, 11, 6, 57, 4, 18, 8}, find the count of each number.

            List<int> list = new() { 23, 4, 8, 4, 23, 11, 6, 57, 4, 18, 8 };

            Dictionary<int, int> countNumbers = new();


            foreach (var number in list)
            {
                if (!countNumbers.TryAdd(number, 1))
                    countNumbers[number]++;
            }

            foreach (KeyValuePair<int, int> element in countNumbers)
            {
                Console.WriteLine($"Key:{element.Key} Value:{element.Value}");
            }

            Console.WriteLine("---------------------");

            // Select element,Count(Element) from List
            //group by element

            //Linq API

            //var dict = list.GroupBy(element => element)
            //    .Select(element => new
            //    {
            //        reqem = element,
            //        say = element.Count(),
            //    });

            //foreach (var data in dict)
            //{
            //    Console.WriteLine($"Reqem:{data.reqem} Say:{data.say}");
            //}

          

            //numbers.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine(x));


            //numbers.OrderBy(x=>x).ToList().ForEach(x => Console.WriteLine(x));

            //numbers.OrderByDescending(x => x).ToList().ForEach(Console.WriteLine);

            //bool result = numbers.All(x => x.Equals(4));
            //Console.WriteLine(result);

            //result = numbers.Any(x => x.Equals(4));
            //Console.WriteLine(result);

            //numbers.Contains(4);

            //Console.WriteLine(numbers.Average());
            //Console.WriteLine(numbers.Where(x => x == 20).FirstOrDefault());
            //    //eger serte uygun tapmadisa hemin deyerin default qiymetin menimsedir.

            //Console.WriteLine(numbers.Where(x=>x==20).First());//serte uygun deyer tapmasa exception atir

            //Console.WriteLine(numbers.Where(x => x == 4).Single());

            //Eger hemin serte deyer yoxsa ve ya 1 deneden coxdusa exception atacaq.

            //Console.WriteLine(numbers.Where(x => x == 4).SingleOrDefault());
            //Egerr hemin serte uygun deyer yoxdusa default deyerin qaytariri yox eger 1 deneden coxdusa Single kimi exception atir.

            //Console.WriteLine(numbers.Sum());

            //numbers.Skip(5).Take(10).ToList().ForEach(Console.WriteLine);

            //if (numbers.Any())
            //{
            //    Console.WriteLine("SAlammmmmmm");
            //}

            //Projecting a list of strings to their lengths(Easy)


            List<string> names = new() { "Azima", "Yusif", "Nijat" };


            names.Select(name => new
            {
                Name = name,
                Length = name.Length
            }).ToList().ForEach(name =>
            {
                Console.WriteLine($"Name:{name.Name}  Length:{name.Length}");
            });

            //Sorting a list of people by age(Easy)
            //Finding the sum of a list of integers(Easy)
            //Finding the maximum age in a list of people(Medium)

            //Calculating the average age of people(Medium)


            //Skipping elements while a condition is true and then taking the rest (Easy) 

            List<int> numbers = new() { 2, 4, 6, 8, 1, 4, 6, 1, 7, 4, 5 };

            numbers.TakeWhile(x=>x%2==0).ToList().ForEach(Console.WriteLine);
        }

        static void HandleMathDelegate(MathOperationHandler handler, int num1, int num2)
        {
            var result = handler.Invoke(num1, num2);
            Console.WriteLine(result);
        }

        static int Sum(int num1, int num2)
        {
            return num1 + num2;
        }

        static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}
