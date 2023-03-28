using System;
using System.Threading;

namespace MultiThreadingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(PrintY1000);
            thread.Start();

            var state = thread.ThreadState;
            // thread.Join(); will make the thread wait here till it finishes - no threading behavior - investigate where it will be useful
            Console.WriteLine("Thread has ended");

            for(var i=0; i<1000; i++)
            {
                Console.WriteLine($"X{i}");
            }

            Console.ReadKey();

        }

        public static void PrintY1000()
        {
            for(var i=0; i<1000; i++)
                Console.WriteLine($"Y{i}");
        }
    }
}
