using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datatype_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            int no = 5;
            //boxing value to object type (Implicit)
            object o = no;
            Console.WriteLine("Object: " + o);
            //unboxing object to value type (Explicit)
            int no1 = (int)o;
            Console.WriteLine("no1: " + no1);
            Console.WriteLine("No1 = {0}", no1);
            Console.WriteLine($"No1= {no1}");

            //Float
            // float no2 = 5;
            //boxing value to object type (Implicit)
            // object o = no2;
            //Console.WriteLine("Object: " + o);
            //unboxing object to value type (Explicit)
            //  float no3 = (float)o;
            //  Console.WriteLine("no3: " + no3);
            // Console.WriteLine("No3 = {0}", no3);
            // Console.WriteLine($"No3= {no3}");

            object ob = 10;
            long l = 12L;
            int val = 12;
            bool b = false;
            Print(l);
            Print(val);
            Print(b);
            Print('A');
            Print(ob);

            sbyte svalue = sbyte.MinValue + 10;
            Print((object)svalue);
            Print(svalue);

            Student student = new Student()
            { StudentId = 1, Marks = 300, Name = "Krunal Tambe" };
            Employee employee = new Employee()
            { EmployeeId = 101, Salary = 60000, Name = "Murali Chobey" };

            Employee emp;
            emp.EmployeeId = 102;
            emp.Name = "Jay Patel";
            emp.Salary = 50000;

            Data.Method(student);
            Data.Method(employee);
            Data.Method(emp);

            //underflow/overflow/Converstion
            Console.WriteLine("Max:{0} ", int.MaxValue);
            Console.WriteLine("Min:{0} ", int.MinValue);

            int data = int.MaxValue;
            unchecked
            {
                int value = int.MaxValue + 1;
                Console.WriteLine("Value: "+value);
            }
            try
            {
                checked
                {
                    Console.WriteLine("Value: " + (data + 1));
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }



            Console.Read();


        }
        static void Print(Boolean b)
        {
            Console.WriteLine($"Type {b.GetType()} and Value {b}");
        }
        static void Print(int value)
        {
            Console.WriteLine($"Type {value.GetType()} and Value {value}");
            Console.WriteLine($"Min Value {int.MinValue} Max Value {int.MaxValue}");
        }
        static void Print(long value)
        {
            Console.WriteLine($"Type {value.GetType()} and value {value}");
            Console.WriteLine($"Min Value {long.MinValue} Max Value {long.MaxValue}");
        }
        static void Print(char ch)
        {
            Console.WriteLine($"Type {ch.GetType()} and Value {ch}");
            Console.WriteLine($"Min value {char.MinValue} Max Value {char.MaxValue}");
            Console.WriteLine($"Min Value {(int)char.MinValue} and Max Value {(int)char.MaxValue}");
        }
        static void Print(object o )
        {
            Console.WriteLine($"Type {o.GetType()} and Value {o}");
            Type objType = o.GetType();
            if(objType == typeof(int))
            {
                Console.WriteLine($"Min value {int.MinValue} Max Value {int.MaxValue}");
            }
            else if(objType == typeof(long))
            {
                Console.WriteLine($"Min Value {long.MinValue} MAx Value {long.MaxValue}");
            }
            else if(o is sbyte)
            {
                Console.WriteLine($"Min Value {sbyte.MinValue} Max Value {sbyte.MaxValue}");
            }
        }
    }
          
}