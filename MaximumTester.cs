namespace MaximumTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MaximumTester<T> where T : IComparable
    {
        /// <summary>
        /// Tests the maximum.
        /// </summary>
        /// <param name="entry1">The entry1.</param>
        /// <param name="entry2">The entry2.</param>
        /// <param name="entry3">The entry3.</param>
        /// <returns></returns>
        public static T TestMaximum(T entry1, T entry2, T entry3)
        {
            // Check the order of entry1 and entry2 and assigning it to maximum
            // CompareTo returns 1 is entry1 > entry2 else -1
            T maximum = entry1.CompareTo(entry2) == 1 ? entry1 : entry2;

            // Check the order of maximum and entry3 and assigning it to maximum
            maximum = maximum.CompareTo(entry3) == 1 ? maximum : entry3;
            Console.WriteLine("The maximum string is {0}", maximum);
            return maximum;
        }
    }
}
