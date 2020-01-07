using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class Aeroplane_IS : IAeroplane
    {
        public void Fly()
        {
            Console.WriteLine("Fly implemented inside Aeroplane with interface segregation");
        }
    }
}
