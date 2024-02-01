using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
    class Car : IVehical
    {
        public void DriveCar()
        {
            Console.WriteLine("Car is being driver!");
        }

        #region IVehical members
        public void Drive()
        {
            Console.WriteLine("Car is being driven!");
        }
        #endregion
    }
}
