/* *
 * Created by Lewis Johnson.
 * You can use this in anyway you want ! Fork on GitHub and add too the library.
 * 
 * This class is a simple calculator.
 * 
 * Example input: 5 * 4598 + 718 + 5 * 3988 * 2 + 52 + 365 * 46 % 4877
 * 
 * CAUTION: This is currently set up so % is the last operator. This is necessary in this calculator.
 * 
 * And it will return your answer.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;


namespace MathsClassLibrary
{
    class ModularCalculator
    {
        public static string Input(int sum)
        {
            var inputData = new List<string>() {""};
            while (inputData[0] != "%")
            {
                inputData = new List<string>(Console.ReadLine().Split(' ').ToList());
                sum = Calculate(inputData[0], sum, Convert.ToInt32(inputData[1]));
            }

            sum = Calculate(inputData[0], sum, Convert.ToInt32(inputData[1]));
            return sum.ToString();
        }

        private static int Calculate(string sign, int result, int operand)
        {
            switch (sign)
            {
                case "+": return result += operand; 
                case "-": return result -= operand;
                case "*": return result *= operand;
                case "%": return result %= operand;
            }
            return -1;
        }

    }
}
