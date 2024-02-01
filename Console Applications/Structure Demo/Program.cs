using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Person p = new Person(1, "Jay", 6000);
            //Person p1 = new Person(1, "Krishna", 6000);
           
            //int id1, id2, salary1, salary2;
           // string name1, name2;
            Console.Write("Enter Id1:- ");
            int id1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name1:- ");
            string name1 = Console.ReadLine();
            Console.Write("Enter Salary1:- ");
            int salary1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Id2:- ");
            int id2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name2:- ");
            string name2 = Console.ReadLine();
            Console.Write("Enter Salary2:- ");
            int salary2 = Convert.ToInt32(Console.ReadLine());

            Person p = new Person(id1,name1,salary1);
            Person p1 = new Person(id2,name2,salary2);




            if (p.ComparePerson(p1))
            {
                Console.WriteLine("Both the object are same");
            }
            else
            {
                Console.WriteLine("Not Same");
            }
            Console.WriteLine($"Person ID:- {p.GetPersonId()}");
            Console.WriteLine($"Person Name:- {p.Name}");
            Console.Read();
        }
    }
}
