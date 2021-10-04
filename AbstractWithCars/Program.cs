using System;
using System.Collections.Generic;

namespace AbstractWithCars
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cars> car = new List<Cars>();
            car.Add(new Toyota(true));
            car.Add(new Nissan(true));
            
            
        }
    }
}
