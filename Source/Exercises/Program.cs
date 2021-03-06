﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Preconditions

            // What's the definition of square root from mathematics?
            //
            // Data types in math vs .NET/C#
            //
            // 
            //
            // Examples:
            // 
            //   Sqrt(9) = 3                     because 3^2 = 3 * 3 = 9 
            //   Sqrt(2) = 1.4142135623731...    because 1.4142135623731...^2 = 2
            //   
            // The square root of two isn't a 
            // 
            var xxxx = (Math.Sqrt(2) * Math.Sqrt(2));
            Console.WriteLine(xxxx);

            Console.WriteLine("------------------------------");

            #endregion

            double x = 2.0;
            double y = Math.Sqrt(x) * Math.Sqrt(x);
            bool bool6 = (x == y);
            Console.WriteLine("The value of bool6 is : {0}", bool6);
            //
            // Why did that happen? Check the values for x and y
            // by uncommenting the three lines below:
            //
            Console.WriteLine("x is : {0}", x);
            Console.WriteLine("y is : {0}", y);
            Console.WriteLine("x - y is : {0}", (x - y));
        }
        
        static int Main1(string[] args)
        {
            uint precision;
            bool isPrecisionPositiveInteger = uint.TryParse(args[0], out precision);
            if (!isPrecisionPositiveInteger || precision == 0)
            {
                Console.WriteLine("Precision '{0}' must be larger than zero", args[0]);
                return 1;
            }
            double approximatePi = 0.0;
            for (int i = 1; i <= precision; i += 2)
            {
                int term1Denominator = 2 * i - 1;
                int term2Denominator = 2 * (i + 1) - 1;
                //Console.WriteLine("4/{0} 4/{1} ", term1Denominator, term2Denominator);
                approximatePi += 4.0 / term1Denominator - 4.0 / term2Denominator;
                //Console.WriteLine(approximatePi);
            }
            Console.WriteLine(approximatePi);
            return 0;
        }
    }
}
