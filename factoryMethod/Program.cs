using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factoryMethod
{
    class Program
    {
        static void main()
        {
            Console.WriteLine("Enter First number");
            string input = Console.ReadLine();
            double n1, n2, n3;
            bool result = Double.TryParse(input, out n1);

            if (!result)
            {
                Console.WriteLine("Number is required");
                return;
            }
            Console.WriteLine("Enter Second number");
            result = Double.TryParse(Console.ReadLine(), out n2);

            if (!result)
            {
                Console.WriteLine("Number is required");
                return;
            }

            Console.WriteLine("Enter Third number");
            result = Double.TryParse(Console.ReadLine(), out n3);

            if (!result)
            {
                Console.WriteLine("Number is required");
                return;

                Console.WriteLine("Which one do you want? (add, multiple or substract)");
                CalculationFactory factory = new CalculationFactory();
                ICalculation obj = factory.GetCalculate(Console.ReadLine());

                obj.Calculation(n1, n2, n3);

            }
        }
    }
}
