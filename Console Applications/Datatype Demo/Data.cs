using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatype_Demo
{
    class Data
    {
        public static void Method(Object o)
        {
            if(typeof(Student) == o.GetType())
            {
                Student student = (Student)o;
                Console.WriteLine($"Student Name:- {student.Name} " + $"Marks:- {student.Marks}");
            }
            else if(o is Employee)
            {
                Employee employee = (Employee)o;
                Console.WriteLine($"Employee Name:- {employee.Name} " + $"Salary:- {employee.Salary}");
            }
        }
    }
}
