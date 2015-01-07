using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathsClassLibrary.Generics.Implementation
{
    class Int64Calc : ICalc<Int64>
    {
        public long Sum(long arg1, long arg2)
        {
            return arg1 + arg2;
        }

        public long Difference(long arg1, long arg2)
        {
            return arg1 - arg2;
        }

        public long Multiply(long arg1, long arg2)
        {
            return arg1*arg2;
        }

        public long Divide(long arg1, long arg2)
        {
            return arg1/arg2;
        }

        public long Divide(long arg1, int arg2)
        {
            return arg1/arg2;
        }

        public int Compare(long arg1, long arg2)
        {
            return arg1.CompareTo(arg2);
        }
    }
}
