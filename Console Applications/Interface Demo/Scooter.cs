using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
    class Scooter : IVehical
    {
        public void DriveScooter()
        {
            Console.WriteLine("Scooter is being driven");
        }
        #region IVehical members
        public void Drive()
        {
            Console.WriteLine("Scooter is Driven");
        }
        #endregion
    }
}
