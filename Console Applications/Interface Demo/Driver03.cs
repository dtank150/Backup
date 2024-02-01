using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
    class Driver03
    {
        public void Driveobject(IVehical objVehical)
        {
            Console.WriteLine("Driver is now driving a vehicle: {0}.",objVehical.GetType().Name);
            objVehical.Drive();
        }
    }
}
