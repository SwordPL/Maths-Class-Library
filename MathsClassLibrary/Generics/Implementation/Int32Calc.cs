using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsClassLibrary.Generics.Implementation
{
    class Int32Calc : ICalc<Int32>
    {
        public int Sum(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        public int Difference(int arg1, int arg2)
        {
            return arg1 - arg2;
        }

        public int Multiply(int arg1, int arg2)
        {
            return arg1*arg2;
        }

        public int Divide(int arg1, int arg2)
        {
            return arg1/arg2;
        }

        public int Compare(int arg1, int arg2)
        {
            return Difference(arg1, arg2);
        }
    }
}
