using System;
using System.Collections.Generic;
using System.Text;

namespace MaximumTest
{
    public class MaximumTester
    {
        /// <summary>
        /// UC1- Tests the maximum integer
        /// </summary>
        /// <param name="number1">The number1.</param>
        /// <param name="number2">The number2.</param>
        /// <param name="number3">The number3.</param>
        /// <returns></returns>
        public static int TestMaximum(int number1, int number2, int number3)
        {
            // Check the order of num1 and num2 and assigning it to maximum
            // CompareTo returns 1 is num1 > num2 else -1
            int maximum = number1.CompareTo(number2) == 1 ? number1 : number2;

            // Check the order of maximum and num3 and assigning it to maximum
            maximum = maximum.CompareTo(number3) == 1 ? maximum : number3;
            Console.WriteLine("The maximum number is {0}",maximum);
            return maximum;
        }
    }
}
