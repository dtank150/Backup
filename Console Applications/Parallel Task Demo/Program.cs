using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace Parallel_Task_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            Console.WriteLine("Task Start");
            Start(10, watch);
            Console.WriteLine($"Total time taken {watch.ElapsedMilliseconds}");
            ParallelStart(10, watch);
            Console.WriteLine($"Total time taken {watch.ElapsedMilliseconds}");
            ParallelStart(new int[] { 3, 4, 5, 8, 9, 10, 4, 5 }, watch);
            Console.WriteLine($"Total time taken {watch.ElapsedMilliseconds}");
            Console.WriteLine("----------Completed------------");
            Console.ReadKey();
        }
        public static void Start(int value, Stopwatch watch)
        {
            watch.Start();
            for(int loop = 1; loop <= value; loop++)
            {
                Console.WriteLine($"Task over :" + $"{Thread.CurrentThread.ManagedThreadId} : {loop}");
                System.Threading.Thread.Sleep(1000);
            }
            watch.Stop();
        }
        public static void ParallelStart(int value, Stopwatch watch)
        {
            watch.Restart();
            System.Threading.Tasks.Parallel.For(1, value + 1, loop =>
              {
                  Console.WriteLine($"Task over: {Task.CurrentId} : {loop}");
                  System.Threading.Thread.Sleep(1000);
              });
            watch.Stop();
        }
        public static void ParallelStart(int[] arr, Stopwatch watch)
        {
            watch.Restart();
            System.Threading.Tasks.Parallel.ForEach(arr, loop =>
            {
                Console.WriteLine($"Task over: {Task.CurrentId} : {loop}");
                System.Threading.Thread.Sleep(1000);
            });
            watch.Stop();
        }
    }
}
