using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MathsClassLibrary.Generics.Implementation;

namespace MathsClassLibrary.Generics
{
    class Number<T>
    {
        private T value;

        public Number(T val)
        {
            value = val;
        }

        private static Type GetCalculator()
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
    }
}
