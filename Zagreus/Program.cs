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
            int? WeaponScore = null;

            if(WeaponScore == null)
            {
                Console.WriteLine("Score is null");
            }

            if (!WeaponScore.HasValue)
            {
                Console.WriteLine("Score is null");
            }



            Console.ReadLine();
        }

    }
}