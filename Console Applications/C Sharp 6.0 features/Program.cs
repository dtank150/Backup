using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_6._0_features
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Niki";

            Console.WriteLine($"3 + 5 = {Add(3, 5)}");
            string check = value?.ToUpper();
            Console.WriteLine(check);

            int.TryParse("10", out int no);
            Console.WriteLine(no);
           

            //Tuple
            Tuple<int, int> GetMinMax(IEnumerable<int> arr1)
        {
            return new Tuple<int, int>(arr1.Min(), arr1.Max());
        }
        (int min, int max) GetMinMax1(IEnumerable<int> arr1)
        {
            return (arr1.Min(), arr1.Max());
        }

        List<int> arr = new List<int> { 1, 5, 2, 7, 8 };
        Tuple<int, int> minmax = GetMinMax(arr);
        arr.ForEach(each => Console.Write("{0,5}",each));
        Console.WriteLine("\n Minimum {0}, Maximum {1} ",minmax.Item1, minmax.Item2);

            var result = GetMinMax1(arr);
            Console.WriteLine("Minimum {0}, Maximum {1} ", result.min, result.max);
            var tuple = (10, "text");
            var (a, b) = tuple;//implicitely destructing
            (int c, string d) = tuple;//explicitely destructing
            int e;
            string f;
            (e, f) = tuple;//destring string variable
            var tuples = (1, 2, 3, 4);
            var (x, y, _, _) = tuples;


            Console.ReadKey();
        }
        //An expression-bodied method consists of a single expression that returns a value whose type
        // mathch the method's return type, or, for methods that return void 
        public static int Add(int no1, int no2) => no1 + no2;

       

    }
}
