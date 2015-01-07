/* *
 * Created by Lewis Johnson.
 * You can use this in anyway you want ! Fork on GitHub and add too the library.
 * 
 * This class is for simple maths functions.
 * It is recommended that you turn on outlining.
 */

using System;
using MathsClassLibrary.Generics;

namespace MathsClassLibrary
{
    public class SimpleMaths<T>
    {
        public T APlusB(Number<T> a, Number<T> b)
        {
            return a + b;
        }

        public T ArithmicProgression(Number<T> a, Number<T> b, int c)
        {
            //First term        : a
            //Common Differnce  : b
            //Number of terms   : c
            T result = default(T);

            for (var i = 1; i < c; i++)
            {
                a += b;
                result += a;
            }
            return result;
        }

        public T MinOrMaxOfTwo(Number<T> a, Number<T> b, bool minimum)
        {
            return minimum ? Number<T>.Min(a, b) : Number<T>.Max(a, b);
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
