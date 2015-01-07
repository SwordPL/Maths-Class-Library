using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsClassLibrary.Generics.Implementation
{
    class DoubleCalc : ICalc<Double>
    {
        public double Sum(double arg1, double arg2)
        {
            return arg1 + arg2;
        }

        public double Difference(double arg1, double arg2)
        {
            return arg1 - arg2;
        }

        public double Multiply(double arg1, double arg2)
        {
            return arg1*arg2;
        }

        public double Divide(double arg1, double arg2)
        {
            return arg1/arg2;
        }

        public double Divide(double arg1, int arg2)
        {
            return arg1/arg2;
        }

        public int Compare(double arg1, double arg2)
        {
            return arg1.CompareTo(arg2);
        }
    }
}
