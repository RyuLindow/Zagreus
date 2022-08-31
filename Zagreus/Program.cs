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
            Console.WriteLine("Zagreus uses weapons with a score of {0}", CalculateWeaponScore.GetScores("Godkiller"));


            Console.ReadLine();
        }

    }
}