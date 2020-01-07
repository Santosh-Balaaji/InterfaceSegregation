using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    // This class provides an example of how an interface is implemented without Interface Segreagation
    class MultiFunctionalCar : IVehicle  //Without interface segregation
    {
        public void Drive()
        {
            Console.WriteLine("Drive method");
        }

        public void Fly()
        {
            Console.WriteLine("Inside Fly");
        }
    }

    public class Car : IVehicle 
    {
        public void Drive()
        {
            Console.WriteLine("Implementing Drive Functionality");
        }

        public void Fly()   // Implementing the method without actual functionality implementation
        {
            throw new NotImplementedException();
        }
    }

    public class Aeroplane : IVehicle
    {
        public void Drive()     // Implementing the drive method without actual need of  the method
        {
            throw new NotImplementedException();
        }

        public void Fly()
        {
            Console.WriteLine("Implementing Fly Functionality");
        }
    }
}
