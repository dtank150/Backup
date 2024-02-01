using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_7_Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Task Start:- ");

            Parallel.For(1, 1001, i =>
            {
                if (IsPrime(i))
                {
                    Console.Write(i + " ");
                }
            });
            Console.WriteLine();
            Console.WriteLine("------Completed-------");
            Console.ReadKey();
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number <= 3) return true;

            if (number % 2 == 0 || number % 3 == 0) return false;

            for (int i = 5; i * i <= number; i += 6)
            {
                if (number % i == 0 || number % (i + 2) == 0) return false;
            }

            return true;
        }
    }
}
