using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = { "Niki", "Anjali", "Raj", "Gopal", "Viraj", "Devansh" };
            var result = (from each in names where each.Length >= 6 select each).ToArray();
            Array.ForEach(result, each => Console.WriteLine(each));

            List<Employee> employee = new List<Employee>();

            employee.Add(new Employee() { Id = 4, Name = "Fourth Employee", Age = 18 });
            employee.Add(new Employee() { Id = 2, Name = "Second Employee", Age = 35 });
            employee.Add(new Employee() { Id = 5, Name = "Fifth Employee", Age = 29 });
            employee.Add(new Employee() { Id = 3, Name = "Third Employee", Age = 42 });
            employee.Add(new Employee() { Id = 1, Name = "First Employee", Age = 27 });

            Console.WriteLine("List of the employee in the collection");
            foreach(Employee e in employee)
            {
                Console.WriteLine("{0},{1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();

            Employee[] employeesCopy = new Employee[employee.Count];
            employee.CopyTo(employeesCopy);
            Array.Sort(employeesCopy);
            Console.WriteLine("List of employee - After using Icomparable");
            foreach (Employee e in employeesCopy)
            {
                Console.WriteLine("{0},{1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();
            //Array.Reverse(employeeCopy)
            Console.WriteLine("in Desending Order of ID");
            for(int i = employeesCopy.Length - 1; i > -1; i--)
            {
                Console.WriteLine("{0},{1,-20} {2}", employeesCopy[i].Id, employeesCopy[i].Name, employeesCopy[i].Age);
            }
            Console.WriteLine();
            Console.WriteLine("Orignal Data");
            foreach(Employee e in employee)
            {
                Console.WriteLine("{0},{1,-20} {2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to continue....");
            Console.ReadKey();
            Console.Clear();
            //LINQ
            var query = from e in employee
                        orderby e.Name
                        select e;
            Console.WriteLine("list of the employee in the collection -After Sortng");
            foreach(Employee e in query)
            {
                Console.WriteLine("{0},{1,-20},{2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();
            Console.WriteLine("list of the employee in the collection -Original Data");
            foreach (Employee e in query)
            {
                Console.WriteLine("{0},{1,-20},{2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();
            Console.WriteLine("list of the employee in the collection and filtering it (Original Data)");
            foreach (Employee e in employee)
            {
                if(e.Age < 30) {
                    Console.WriteLine("{0},{1,-20},{2}", e.Id, e.Name, e.Age);
                }
                
            }
            Console.WriteLine();
            var query2 = from e in employee
                         where e.Age < 30
                         orderby e.Age descending
                         select e;
            Console.WriteLine("List of employee in the collection -After Filtering");
            foreach(Employee e in query2)
            {
                Console.WriteLine("{0},{1,-20},{2}", e.Id, e.Name, e.Age);
            }
            Console.WriteLine();

            //LINQ with Projection
            var query3 = from e in employee
                         select new             //Anonymous Object
                         {
                             ObjectId = e.Id,
                             e.Name,
                             e.Age,
                             Address = $"Address #{e.Id} Some City"
                         };
            Console.WriteLine("List of objects using LINQ after Projection");
            foreach(var e in query3)
            {
                Console.WriteLine("{0},{1,-20},{2},{3}", e.ObjectId, e.Name, e.Age, e.Address);
            }
            Console.WriteLine();

            var q1a = from e in employee
                      select e;
            var q1b = employee.Select(e => e);
            var q2a = from e in employee
                      where e.Age < 30
                      select e;
            var q2b = employee.Where(e => e.Age < 30);
            var q3a = from e in employee
                      orderby e.Name descending
                      where e.Age < 30
                      select e;
            var q3b = employee.Where(e=>e.Age < 30)
                              .OrderByDescending(e=>e.Name);
            var q2c = from e in q2a
                      orderby e.Name descending
                      select e;
            foreach (var e in q2c)       //LINQ Query will be excute here!
            {
            }

            Employee thirdEmployee = (from e in employee
                                      where e.Id == 3
                                      select e).SingleOrDefault();

            bool doesShramaExist = employee.Any(e => e.Name == "Sharma");

            var paginationEmployee = employee.Skip(2).Take(3);
            var paginationEmployee2 = (from e in employee select e).Skip(2).Take(3);
            int maxage = employee.Max(each => each.Age);
            var res = from each in employee where each.Age == maxage select each;
            int sum = employee.Sum(each => each.Age);
            var re = from each in employee where each.Age == sum select each;
            //Avrage
            int avg = sum / employee.Count();
            var r = from e in employee where e.Age > avg select e;

            /*var innerJoin = from s in studentlist //outer sequence
                            join st in standardlist//inner sequence
                           standarlist on s.standardId equals st.standardId//key selector
                            select new {//result selector
                                        StudentName = s.StudentName,
                                        StandardName = st.StandardName
                                        }*/
            Console.Read();
        }
    }
}
