using System.Diagnostics.Metrics;
using System.Net.NetworkInformation;
using System;

namespace MultiThreading
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Main Thread Start");

            //Thread thread = new Thread(Task);

            //List<Task> tasks = new()
            //{
            //    Task.Run(()=>{ Console.WriteLine("Our program is started");}),
            //    Task.Run(TaskForMultiThr),
            //    Task.Run(()=>{ Console.WriteLine("Our program is finished");})
            //};

            //await Task.WhenAll(tasks);

            //Task.Run(TaskForMultiThr).Wait();
            //Console.WriteLine("Our program is finished");
            //Thread thread1 = new Thread(Example1);
            //Thread thread2 = new Thread(Example2);
            //thread1.Start();
            //thread2.Start();

            //await Run();
            //Task 1: Simple Thread Creation
            //Create a simple console application that creates a thread to print numbers from 1 to 10.
            //Thread thread1 = new(PrintNumbers);
            Thread thread2 = new(PrintNumbers2);

            //thread1.Start();
            //thread2.Start();


            //Task 2: Simple Task Creation
            //Create a simple console application that uses a Task to print numbers from 1 to 10.

            //await Task.Run(PrintNumbers);
            //await Task.Run(PrintNumbers2);

            //Task 3: Task with Result
            //Create a simple console application that uses a Task to perform a calculation and return the result.

            //Task 4: Using Task.Delay
            //Create a simple console application that uses a Task to print a message after a delay.
            //Thread.Sleep(2000);
            //await Task.Delay(2000);
            //await Task.Run(() => { Console.WriteLine("Samir Velioglu"); });

            //Console.WriteLine("Main Thread Finish");

            // Task 5: Simple Timer Using Task.Delay
            //Create a simple console application that uses a Task to act as a timer, printing a message every second for 5 seconds.

        }

        static async Task PrintNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Number:" + i + "  ThreadId:" + Thread.CurrentThread.ManagedThreadId);
            }
        }
        static void PrintNumbers2()
        {
            for (int i = 10; i < 20; i++)
            {
                Thread.Sleep(1000);
                Console.WriteLine("Number:" + i + "  ThreadId:" + Thread.CurrentThread.ManagedThreadId);
            }
        }

        static async Task Run()
        {
            await Task.Run(TaskForMultiThr);
        }

        static void TaskForMultiThr()
        {
            Console.WriteLine("Task Method is started");
            for (int i = 0; i < 1_000_000_000; i++)
            {

            }
            Console.WriteLine("Task Method is finished");
        }
        static void Example1()
        {
            Console.WriteLine("Example 1 ise dusdu");

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine("Example 1 bitdi");
        }
        static void Example2()
        {
            Console.WriteLine("Example 2 ise dusdu");

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine("Example 2 bitdi");
        }

    }
}
