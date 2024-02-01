using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Demo
{
    class Driver01
    {
        public void DriveTypedObject(Car objCar)
        {
            Console.WriteLine("Driver is now driving a Car");
            objCar.DriveCar();
        }

        public void DriveTypedObject(Scooter objScooter)
        {
            Console.WriteLine("Driver is now driving a Scooter");
            objScooter.DriveScooter();
        }
    }
}
