using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_3._0_Features
{
    class Program
    {
        static void Main(string[] args)
        {
            //only use with local variable
            var no = 5;
            //not allowed
            //var value1;
            //null initialization not allowed
            //var value = nul;

            Console.WriteLine(no.GetType());
            //following statement not possible
            //no = "Niki";
            //implicitly typed arrays.
            var items = new[] { "Java", "C++", "Python", "C"};
            Array.ForEach(items, each => Console.WriteLine($"{each}:{each.Length}"));
            Array.ForEach(items, each => Console.Write(each[0] == 'C' ? each + "\t" : ""));
            Console.WriteLine();
            //var I = items.Where(each => each[0] == 'C');
            //foreach(var i in I)
            //{
            //    Console.WriteLine(i.ToString());
            //}

            //object initializers Inside a pair of curly brackets {}
            //we initiate members of a class through a series of assignments
            Person p = new Person() { Id = 1, Name = "Niki" };

            //collection initializers
            List<Person> list = new List<Person>()
            {
                new Person(){Id = 1, Name = "Niki"},
                new Person(){Id = 2, Name = "Kiran"},
            };
            //Anonymous types are allow data types to encapsulate
            //a set of properties into a single object
            //without having to first explicitly define a type.
            //Anonymous types must be stored in variables
            //declared with the var keyword
            var x = 10;
            var student = new { Name = "Jay", RollNo = 5 };
            Console.WriteLine($"{student.RollNo} : {student.Name}");
            Console.WriteLine(student.GetType());

            String name = "Niki";
            Console.WriteLine($"{name}: "+name.LowerUpper());
            String digit = "Niki1234";
            Console.WriteLine($"{digit}: "+digit.CountDigit());
            Console.Read();
        }
    }
    class Person { 
        //Auto Implemented Property

        public int Id { get; set; }
        public string Name { get; set; }
    }
    public static class StringExtension {
        public static string LowerUpper(this string value)
        {
            string reply = "";
            foreach (char ch in value)
            {
                if (char.IsUpper(ch))
                    reply += Char.ToLower(ch);
                else if (char.IsLower(ch))
                    reply += Char.ToUpper(ch);
                else
                    reply += ch;
            }
            return reply;
        }
        public static int CountDigit(this string value)
        {
            int count = 0;
            foreach(char ch in value)
            {
               // count += char.IsDigit(ch) ? 1 : 0;
                if (char.IsDigit(ch))
                    count += 1;
            }
            return count;
           // return value.Count(ch => Char.IsDigit(ch));
        }
    }
   
}
