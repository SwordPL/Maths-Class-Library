/* *
 * Created by Lewis Johnson.
 * You can use this in anyway you want ! Fork on GitHub and add too the library.
 * 
 * This class is for simple maths functions.
 * It is recommended that you turn on outlining.
 */

using System;

namespace MathsClassLibrary
{
    public class SimpleMaths
    {
        public int APlusB(int a, int b)
        {
            var result = a + b;
            return result;
        }

        public int ArithmicProgression(int a, int b, int c)
        {
            //First term        : a
            //Common Differnce  : b
            //Number of terms   : c
            var result = 0;

            for (var i = 1; i < c; i++)
            {
                a += b;
                result += a;
            }
            return result;
        }

        public int MinOrMaxOfTwo(int a, int b, bool minimum)
        {
            return minimum ? Math.Min(a, b) : Math.Max(a, b);
        }

        public int MinOrMaxOfThree(int a, int b, int c, bool minimum)
        {
            return minimum ? Math.Min(Math.Min(a, b), c) : Math.Max(Math.Min(a, b), c);
        }

        public double RoundedDivision(double a, double b, double c, bool useThree)
        {
            return useThree ? Math.Round(a / b / c) : Math.Round(a/b);
        }

        public double FahrenheitToCelsius(double fahrenhiet, bool roundResult)
        {
            fahrenhiet -= 32;
            fahrenhiet = fahrenhiet / 1.8;
            return roundResult ? Math.Round(fahrenhiet) : fahrenhiet;
        }

        public double CelsiusToFahrenheit(double celsius, bool roundResult)
        {
            celsius += 32;
            celsius = celsius * 1.8;

            return roundResult ? Math.Round(celsius) : celsius;
        }
    }
}
