using System;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncronusDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Task1();
            Task2();
            Task3();
            Task4();
            Console.ReadLine();
        }
        public static async Task Task1()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 1 started");
                Thread.Sleep(6000);
                Console.WriteLine("Task1 completed");
            });

             Console.Out.WriteLine("Hello");

        }
        public static async void Task2()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 2 started");
                Thread.Sleep(2000);
                Console.WriteLine("Task2 completed");
            });

        }
        public static async void Task3()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 3 started");
                Thread.Sleep(5000);
                Console.WriteLine("Task3 completed");
            });
           
        }

        public static async void Task4()
        {
            await Task.Run(() =>
            {
                Console.WriteLine("Task 4 started");
                Thread.Sleep(1000);
                Console.WriteLine("Task4 completed");

            });

          

        }

        

        }
    }
