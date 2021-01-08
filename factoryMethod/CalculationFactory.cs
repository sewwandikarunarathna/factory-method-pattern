using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod
{
    public class CalculationFactory
    {
        public ICalculation GetCalculate(string type)
        {
            ICalculationonj = null;
            if (type.ToLower().Equals("addition"))
            {
                object = new Addition();
            }
            else if (type.ToLower().Equals("multiple"))
            {
                object = new Multiple();
            }
            else if (type.ToLower().Equals("substract"))
            {
                object = new Substract();
            }
            else
            {
                Console.WriteLine("Sorry, this is wrong!");
            }

            return object;
        }
    }
}
