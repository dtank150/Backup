using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_4._0_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic runtime;
            runtime = "Niki";
            Console.WriteLine($"{runtime} {runtime.GetType()}");

            runtime = 123;
            Console.WriteLine($"{runtime} {runtime.GetType()}");

            Console.WriteLine($"1 + 5 = {DynamicMethod(1, 5)}");
            Console.WriteLine($"ABC+XYZ = {DynamicMethod("ABC", "XYZ")}");
            Console.WriteLine($"123+XYZ = {DynamicMethod(123, "XYZ")}");
            Console.WriteLine($"12.34+XYZ = {DynamicMethod(12.34, "XYZ")}");

            Console.WriteLine($"1 + 3 = {Method(1, 3)}");//both are positional arguments
            Console.WriteLine($"1 + Default(4) = {Method(1)}");//positiona and default arguments
            Console.WriteLine($"4 + 1 = {Method(n2:1,n1:4)}");//optional arguments
            Console.WriteLine($"5 + 4 = {Method(5,n2:4)}");//positional argument followed by optional arguments
            //optional arguments can not come before positional arguments


            Console.Read();

        }
        public static dynamic DynamicMethod(dynamic arg1, dynamic arg2)
        {
            var ans = arg1 + arg2;
            return ans;
        }
        public static int Method(int n1, int n2 = 4)
        {
            return n1 + n2;
        }

        
    }
}
//var is statically typed and dynamic is dynamically typed
//var need to be intialized
//multiple intialition with different types does not support with var.
//var is not used as method parameter and return type.
