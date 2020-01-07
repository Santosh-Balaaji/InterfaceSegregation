using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregation
{
    public class Car_IS : ICar
    {
        public void Drive()
        {
            Console.WriteLine("Drive with Interface Segregation");
        }
    }
}
