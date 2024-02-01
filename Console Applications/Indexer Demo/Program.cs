using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Data data;
            int size;
            Console.WriteLine("Enter the size of array: ");
            bool result = int.TryParse(Console.ReadLine(), out size);
            if(result)
            {
                data = new Data(size);
            }
            else
            {
                data = new Data(2);
            }
            Student student = new Student()
            { Name = "Niki", Marks = 450, StudentId = 1 };
            data.SetData(student, 1);
            Student student1 = new Student() { Name = "Jay", Marks = 460, StudentId = 2 };
            //data.SetData(student1, 2);
            data[1] = student1; //set indexer
            Student temp;
            if (data.GetData(1, out temp))
                Console.WriteLine($"{temp.StudentId}\t{temp.Name}\t{temp.Marks}");
            temp = data[1]; // get indexer call here;
            Console.WriteLine(temp);
            GenericIndexer<String> genericIndexer = new GenericIndexer<string>();

            genericIndexer[0] = "Niki Bachani";
            genericIndexer[1] = "Jay Patel";
            Console.WriteLine($"Value from generic(String) indexer " + $"{genericIndexer[0]}");

            GenericIndexer<Student> studentIndexer = new GenericIndexer<Student>();
            studentIndexer[0] = student;
            studentIndexer[1] = student1;
            Console.WriteLine($"Value from generic(Student) indexer "+ $"{ studentIndexer[0]}");
            Console.Read();
        }
    }
}
