using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexer_Demo
{
    class Data
    {
        Student[] students;

        int _size;

        public Data()
        {
            students = new Student[0];
        }
        public Data(int size)
        {
            students = new Student[size];
            _size = size;
        }
        public void SetSize(int size)
        {
            _size = size;
            students = new Student[size];
        }
        public bool SetData(Student student, int pos)
        {
            if(pos >= 1 && pos <= students.Length)
            {
                students[pos - 1] = student;
                return true;
            }
            return false;
        }
        public bool GetData(int pos, out Student student)
        {
            if(pos >= 1 && pos <= students.Length)
            {
                student = students[pos - 1];
                return true;
            }
            student = new Student() { Name = "Invalid" };
            return false;
        }
        //indexer method
        public Student this[int index]
        {
            get
            {
                return students[index];
            }
            set
            {
                students[index] = value;
            }
        }
    }
}
