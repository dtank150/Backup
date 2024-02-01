using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxMin
{
    class Program
    {
        static void Main(string[] args)
        {
            int min, max;
            MaxMin(6, 12, out max, out min);
            Console.WriteLine($"Max:- {max} \n Min:- {min}");

            Console.Read();
        }
        static void MaxMin(int no1, int no2,out int max, out int min)
        {
            max = no1 > no2 ? no1 : no2;
            min = no1 > no2 ? no2 : no1;
        }
    }
}
