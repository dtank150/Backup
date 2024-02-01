using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Task_7_Random_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int[] numbers = new int[10000];

            Parallel.For(0, 1000, i => numbers[i] = r.Next(1, 1001));
            var unique = numbers.GroupBy(e => e).Where(n => n.Count() == 1);

            foreach(var number in unique)
            {
                Thread.Sleep(200);
                Console.WriteLine($"{number.Key} : {number.Count()}");
            }
            Console.WriteLine("------Completed--------");
            Console.ReadKey();
        }
    }
}
