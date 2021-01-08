using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod
{
    class Substract : ICalculation
    {
        public void Calculation(double x, double y, double z)
        {
            Console.WriteLine("x-y-z is {0}", x - y - z);
        }

    }
