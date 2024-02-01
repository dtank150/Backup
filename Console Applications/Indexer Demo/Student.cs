using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Demo
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public override string ToString()
        {
            String output = "";
            output += $"{this.StudentId}\t";
            output += $"{this.Name}\t";
            output += $"{this.Marks}\t";

            return output;
        }
    }
}
