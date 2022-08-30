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
            int num1 = 10;
            int num2 = 20;

            Console.WriteLine("Before swap num1 is : {0} \nnum2 is : {1}", num1, num2);

            Swap(ref num1, ref num2);

            Console.WriteLine("After swap num1 is : {0} \nnum2 is : {1}", num1, num2);


            Console.ReadLine();
        }
        
        public static void Swap(ref int num1, ref int num2)
        {
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}