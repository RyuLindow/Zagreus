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
            int i = 1;

            while(i <= 10)
            {
                if(i % 2 == 0)
                {
                    i++;
                    continue;
                }

                if (i == 9) break;

                Console.WriteLine(i);
                i++;
            }






            Console.ReadLine();
        }
    }
}