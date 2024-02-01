using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Task_Return_Demo
{
    class Demo1
    {
        public static IEnumerable<int> TaskPrime(int from, int to, Stopwatch stopwatch)
        {
            Task<IEnumerable<int>> primeTask = Task<IEnumerable<int>>.Factory.StartNew(() =>
            {
                stopwatch.Restart();
                List<int> list = new List<int>();
                System.Threading.Tasks.Parallel.For(from, to, each =>
                {
                    if (IsPrime(each)) list.Add(each);
                });
                stopwatch.Stop();
                return list;
            });
            return primeTask.Result;
        }
        public static bool IsPrime(int no)
        {
            for(int each = 2; each <= no/2; each++)
            {
                if(no % each == 0)
                {
                    return false;
                }
            }
            return true;
        }
        public static bool OddEven(int no)
        {
            return (no % 2 == 0);
        }
        public static string Reverse(int no)
        {
            String result = String.Empty;
            foreach (char ch in from each in no.ToString().Reverse() select each) { result += ch; };
            return result;


        }
    }

}
