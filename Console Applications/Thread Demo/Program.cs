using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Thread_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("============ Methods are called Synchronously ============");
            Demo01();
            Console.WriteLine();

            Console.WriteLine("============ Methods are called Asynchronously ============");
            Demo02();
            Console.WriteLine();

            Console.Read();
        }
        static void m()
        {
            Console.WriteLine("---- m() callled on Thred: {0}", Thread.CurrentThread.ManagedThreadId);
            System.Threading.Thread.Sleep(3000); // sleep for 3 seconds

        }
        static void n()
        {
            Console.WriteLine("---- n() callled on Thred: {0}", Thread.CurrentThread.ManagedThreadId);
            System.Threading.Thread.Sleep(5000); // sleep for 5 seconds
        }
        public static void Demo01()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            Console.WriteLine("calling m() from Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            m();

            Console.WriteLine("calling n() from Thread: {0}", Thread.CurrentThread.ManagedThreadId);
            n();

            stopwatch.Stop();
            Console.WriteLine("Total Time taken: {0} milliseconds", stopwatch.ElapsedMilliseconds);
        }
        public static void Demo02()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            Console.WriteLine("calling m() from Thread: {0} Asynchronously", Thread.CurrentThread.ManagedThreadId);
            Thread t1 = new Thread(new ThreadStart(Program.m));
            t1.Start();

            Console.WriteLine("calling n() from Thread: {0} Asynchronously", Thread.CurrentThread.ManagedThreadId);
            Thread t2 = new Thread(new ThreadStart(Program.n));
            t2.Start();

            //Note: 
            t1.Join();
            t2.Join();

            stopwatch.Stop();
            Console.WriteLine("Total Time taken: {0} milliseconds", stopwatch.ElapsedMilliseconds);
        }
    }
}
