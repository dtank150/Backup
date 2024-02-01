using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book
    {
        public int BookId;
        private int _rate;

        public String Title { get; set; }

        public int Rate
        {
            get { return _rate; }
            set { _rate = value; }
        }
    }
}
