using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
    class Driver02
    {
        public void DriveObject(object objVehical)
        {
            Console.WriteLine("Driver is now driven a Vehical Object");
            if(objVehical is Car)
            {
                Car objCar = objVehical as Car; //unboxing
                objCar.DriveCar();
            }
            else if(objVehical is Scooter)
            {
                Scooter objScooter = objVehical as Scooter; //unboxing
                objScooter.DriveScooter();
            }
        }
    }
}
