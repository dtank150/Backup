using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Array_List_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList(7);
            list.Add("Krina Joshi");
            list.Add(500);
            list.AddRange(new int[] { 1, 2, 3 });
            list.Add("Manan Patel");
            list.Add("I am Here");
            list.Add("I");
            list.Add("123");
            list.Add(new Student() { Marks = 345, Name = "Jay", StudentId = 1 });

            foreach(object each in list)
            {
                Console.WriteLine(each);
            }
            Console.WriteLine(list.Count);
            Console.WriteLine(list.Capacity);
            Console.Read();

        }
    }
}
