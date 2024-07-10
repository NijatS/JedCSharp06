using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System;

namespace Delegates
{
    internal class Program
    {
        //delegate void MathHandler(int num1, int num2);
        delegate void ShowHandler(string message);
        delegate int MathHandler(int num1, int num2);
        delegate T MathHandlerGen<T>(T num1, T num2);
        delegate string StringHandler(string text);
        delegate int ArrayHandler(int[] array);
        delegate bool PredicatebyNijat<T>(T input);
        delegate void ShowMessageHandler();

        delegate TResult GenericHandler<in T, out TResult>(T inp);
        delegate TResult GenericHandler<in T,in V, out TResult>(T inp,V inp2);
        delegate TResult GenericHandler<in T, in V,in Z, out TResult>(T inp, V inp2,Z inp3);

        //delegate int MathHandlerSquare(int num);

        static void Main(string[] args)
        {
            //ShowHandler handler1 = ShowAnnounce;
            //ShowHandler handler2 = AzerbaijanRule;
            //ShowHandler handler = handler1 + handler2;  


            // handler.Invoke("Everyone can wear short");
            //handler("Nobody must wear short");

            //MathHandler mathHandler1 = Addition;
            //MathHandler mathHandler2 = Subtraction;

            //MathHandler mathHandler = mathHandler1 + mathHandler2;

            //mathHandler(5, 10);


            //MathHandlerGen<int> hand = Addition;
            //MathHandlerGen<double> hand2 = Addition;
            //Console.WriteLine(hand(1,2));
            //Console.WriteLine(hand2(1.2,2.5));
            //ShowHandler handler = ShowLoginMessage;
            //UserLogin("Nicat", "Nicat1232.", handler);

            //Func<int, int> func = Square;

            //Func<int, int, int> fun2 = Addition;

            //Console.WriteLine(fun2(4,4));

            //StringHandler handler = ToUpper;
            //Console.WriteLine(handler("sadasd"));

            //Func<string, string> func = ToUpper;
            //Console.WriteLine(func("dasdad"));

            //ArrayHandler handler = SumArray;
            //Console.WriteLine(handler([2,4,6,82,6]));

            Func<int[], int> func = SumArray;
            //Console.WriteLine(func([2, 4, 6, 82, 6]));

            Action<string> action = ShowLoginMessage;

            //action("Salammmmm");

            PredicatebyNijat<int> predicate = isEven;
            Predicate<int> predicate2 = isEven;
            var result = predicate(4);
            var result2 = predicate2(4);
            //Console.WriteLine(result);
            //Console.WriteLine(result2);


            //Use a Predicate delegate to check if a number is even.


            //* Create a delegate that takes a string as a parameter and prints a greeting message.

            //ShowHandler handler = Greet;
            //handler("Azima");
            //handler("Yusif");

            //*Create a multicast delegate that calls two methods: one that prints a message and another that prints the current date and time.


            ShowMessageHandler handler1 = PrintMessage;
            ShowMessageHandler handler2 = PrintDate;
            ShowMessageHandler handler = handler1 + handler2;
            //handler();
            handler.Invoke();


           //*Use a generic delegate that can work with different data types.
        }
        static void PrintMessage()
        {
            Console.WriteLine("Tasklari zamaninda yazin!!!");
        }
        static void PrintDate()
        {
            Console.WriteLine(DateTime.Now);
        }


        static void Greet(string name)
        {
            Console.WriteLine("Hello " + name);
        }
        static void UserLogin(string userName, string password, ShowHandler handler)
        {
            if (userName == "Nicat" && password == "Nicat123.")
            {
                handler("You can access system");
            }
            else
            {
                handler("You cannot access system");
            }
        }
        public static bool isEven(int number)
            => number % 2 == 0;
        public static void ShowLoginMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ResetColor();
        }
        public static string ToUpper(string text)
        {
            return text.ToUpper();
        }
        public static int SumArray(int[] array)
        {
            return array.Sum();
        }
        public static int Square(int number)
            => number * number;

        public static void ShowAnnounce(string message)
        {
            Console.WriteLine($"Rule:{message}");
        }
        public static void AzerbaijanRule(string message)
        {
            Console.WriteLine($"Azerbaijan Rule:not {message}");
        }
        public static int Addition(int num1, int num2)
           => num1 + num2;
        public static double Addition(double num1, double num2)
      => num1 + num2;
        public static int Subtraction(int num1, int num2)
        => num1 - num2;
        public static int Multiply(int num1, int num2)
        => num1 * num2;
        public static int Divide(int num1, int num2)
        => num1 / num2;


    }
}
