using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
    class Bus : IVehical
    {
        public void Drive()
        {
            Console.WriteLine("Bus is being driven");
        }
    }
}
