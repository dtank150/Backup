using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_Return_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            List<int> list = new List<int>();
            stopwatch.Start();
            //foreach(int v in Enumerable.Range(2, int.MaxValue-1))
            foreach (int v in Enumerable.Range(2, 100000))
            {
                if(Demo1.IsPrime(v)) { list.Add(v); }
            }
            stopwatch.Stop();
            Console.WriteLine("Time :  " + stopwatch.ElapsedMilliseconds);

            List<int> pList = new List<int>();
            stopwatch.Restart();
            // System.Threading.Tasks.Parallel.For(2, int.MaxValue, each =>    
            System.Threading.Tasks.Parallel.For(2, 100000, each =>
            {
                if(Demo1.IsPrime(each)) { pList.Add(each); }
            });
            stopwatch.Stop();
            Console.WriteLine("Time :  " + stopwatch.ElapsedMilliseconds);
            List<int> tList = new List<int>();
            // tList = Demo1.TaskPrime(2, (int.MaxValue-1), stopwatch).ToList();
            tList = Demo1.TaskPrime(2, 100000, stopwatch).ToList();
            Console.WriteLine("Time :  " + stopwatch.ElapsedMilliseconds);
            Console.WriteLine("Element: " + tList.Count);
            Console.ReadKey();
            int value = 42345;
            Parallel.Invoke(
                new Action(() => Console.WriteLine(
                    Demo1.OddEven(value) ? $"{value} is Even  " : $"{value} is Odd")),
                new Action(()=>Console.WriteLine(Demo1.IsPrime(value) ?
                $"{value} is Prime ":$"{value} is not Prime")),
                new Action(()=> Console.WriteLine($"Reverse of {value} is " + $"{Demo1.Reverse(value)}"))
                );
            //CallInOne(value);
            Console.ReadKey();

            Task<String> result = ReverseNo(int.MaxValue);
            Console.WriteLine($"Reverse No : {result.Result}");
            Console.ReadKey();

            //PLINQ
            List<int> noList = Enumerable.Range(1, 100).ToList();
            List<int> square = noList.AsParallel().Select(each => each * each).ToList();
            foreach(int each in square) { Console.WriteLine(each); }
            Console.ReadKey();
            Console.WriteLine("Finished");
        }

        public static Task<String> ReverseNo(int no)
        {
            return Task.Run(() =>
            {
                return Demo1.Reverse(no);
            });
        }
    }
}
