using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zagreus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isHadesAGoodGame = true;

            decimal decPiVal = 3.1415926535897932384626433832M;
            decimal decBigNum = 3.0000000000000000000000000011M;


            Console.WriteLine("DEC : PI + bigNum {0}", decPiVal + decBigNum);

            double dblPiVal = 3.14159265358979;
            double dblBigNum = 3.00000000000002;

            Console.WriteLine("DBL : PI + bigNum {0}", dblPiVal + dblBigNum);

            float fltPiVal = 3.141592F;
            float fltBigNum = 3.000002F;

            Console.WriteLine("FLT : PI + bigNum {0}", fltPiVal + fltBigNum);


            Console.WriteLine("Biggest int : {0}", int.MaxValue);
            Console.WriteLine("Smallest int : {0}", int.MinValue);
            Console.WriteLine("Biggest long : {0}", long.MaxValue);
            Console.WriteLine("Smallest long : {0}", long.MinValue);
            Console.WriteLine("Biggest dec : {0}", decimal.MaxValue);
            Console.WriteLine("Smallest dec : {0}", decimal.MinValue);
            Console.WriteLine("Biggest dbl : {0}", double.MaxValue.ToString("#"));
            Console.WriteLine("Smallest dbl : {0}", double.MinValue.ToString("#"));
            Console.WriteLine("Biggest flt : {0}", float.MaxValue.ToString("#"));
            Console.WriteLine("Smallest flt : {0}", float.MinValue.ToString("#"));


            Console.ReadLine(); 
        }

    }
}
