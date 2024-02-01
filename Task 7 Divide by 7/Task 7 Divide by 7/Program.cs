using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_7_Divide_by_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Numbers from 1 to 1000 that can divide by 7:- ");
            Parallel.For(1, 1001, i =>
            {
                if (i % 7 == 0)
                {
                    Console.Write(i + " ");
                }
            });
            Console.WriteLine();
            Console.WriteLine("-------Completed-------");
            Console.ReadKey();
        }
    }
}
