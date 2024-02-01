using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter EmpId:- ");
            int eid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Salary:- ");
            int salary = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Position:- ");
            string pos = Console.ReadLine();
            Console.Write("Enter PersonId:- ");
            int pid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Name:- ");
            string name = Console.ReadLine();
            Console.Write("Enter AdharNo:- ");
            long ano = Convert.ToInt64(Console.ReadLine());

            Employee e = new Employee(eid,salary,pos, Department.Web, pid, name, ano);

            //Employee e = new Employee(101, 80000, "Devloper", Department.Web, 1, "Kiran", 123456789111);

            Console.WriteLine($"{e.EmpId} {e.Name} {e.AdharNo} {e.Id} {e.Salary}");
            Console.Read();

            //Create a array list with employee.
            //Take a employee values from user
            //find out employee department wise. //User
            //Find out all those employee who having minimum Salary.
            //Find out all those employee who having maximum Salary.
        }
    }
}
