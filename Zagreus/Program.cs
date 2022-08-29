using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
using System.Globalization;

namespace Zagreus
{
    internal class Program
    {   
        static void Main(string[] args)
        {
            double num1 = 5;
            double num2 = 0;

            try
            {
                Console.WriteLine("5 / 0 = {0}",
                    Divide(num1, num2));
            }

            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Cannot divide by zero");

                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            catch (Exception ex)
            {
                Console.WriteLine("Vague exception msg");

                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Cleaning up");
            }


            Console.ReadLine();
        }

        static double Divide(double x, double y)
        {
            if (x == y)
            { 
                throw new System.DivideByZeroException();
            }
            return x / y;
        }
    }
}