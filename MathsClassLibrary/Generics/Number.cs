using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsClassLibrary.Generics.Implementation;

namespace MathsClassLibrary.Generics
{
    public class Number<T>
    {
        private T value;

        private static ICalc<T> calc; 

        public Number(T val)
        {
            value = val;
        }

        private static Type GetCalculatorType()
        {
            var type = typeof(T);

            Type calcType;
            if (type == typeof (Int32))
                calcType = typeof (Int32Calc);
            else if (type == typeof(Int64))
                calcType = typeof(Int64Calc);
            else if (type == typeof(Double))
                calcType = typeof(DoubleCalc);
            else throw new InvalidCastException(String.Format("Type is not supported." +
                                                              " Type {0} is not implemented as ICalc<T> partner class" +
                                                              " and cannot be used.", type.Name));
            return calcType;
        }

        public static ICalc<T> Calculator
        {
            get { return calc ?? CreateCalc(); }
        }

        private static ICalc<T> CreateCalc()
        {
            return calc = Activator.CreateInstance(GetCalculatorType()) as ICalc<T>;
        }

        #region Operations
        public static T Sum(T a, T b)
        {
            return Calculator.Sum(a, b);
        }

        public static T Difference(T a, T b)
        {
            return Calculator.Difference(a, b);
        }

        public static T Multiply(T a, T b)
        {
            return Calculator.Multiply(a, b);
        }

        public static T Divide(T a, T b)
        {
            return Calculator.Divide(a, b);
        }

        public static T Divide(T a, int b)
        {
            return Calculator.Divide(a, b);
        }

        public static int Compare(T a, T b)
        {
            return Calculator.Compare(a, b);
        }

        public static T Min(Number<T> a, Number<T> b)
        {
            return a < b ? a : b;
        }

        public static T Max(Number<T> a, Number<T> b)
        {
            return a > b ? a : b;
        }
        #endregion

        #region Operators
        public static implicit operator Number<T>(T a)
        {
            return new Number<T>(a);
        }

        public static implicit operator T(Number<T> a)
        {
            return a.value;
        }

        public static Number<T> operator +(Number<T> a, Number<T> b)
        {
            return Calculator.Sum(a, b);
        }
        public static Number<T> operator -(Number<T> a, Number<T> b)
        {
            return Calculator.Difference(a, b);
        }
        public static Number<T> operator *(Number<T> a, Number<T> b)
        {
            return Calculator.Multiply(a, b);
        }
        public static Number<T> operator /(Number<T> a, Number<T> b)
        {
            return Calculator.Divide(a, b);
        }
        public static Number<T> operator /(Number<T> a, int b)
        {
            return Calculator.Divide(a, b);
        }

        public static bool operator >(Number<T> a, Number<T> b)
        {
            return Calculator.Compare(a, b) > 0;
        }

        public static bool operator <(Number<T> a, Number<T> b)
        {
            return Calculator.Compare(a, b) < 0;
        }

        #endregion
    }
}
