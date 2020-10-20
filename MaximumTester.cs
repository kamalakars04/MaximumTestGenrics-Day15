namespace MaximumTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MaximumTester<T> where T : IComparable
    {
        private T entry1;
        private T entry2;
        private T entry3;

        /// <summary>
        /// Initializes a new instance of the <see cref="MaximumTester{T}"/> class.
        /// </summary>
        /// <param name="entry1">The entry1.</param>
        /// <param name="entry2">The entry2.</param>
        /// <param name="entry3">The entry3.</param>
        public MaximumTester(T entry1, T entry2, T entry3)
        {
            this.entry1 = entry1;
            this.entry2 = entry2;
            this.entry3 = entry3;

        }

        /// <summary>
        /// Tests the maximum.
        /// </summary>
        /// <returns></returns>
        public T TestMaximum()
        {
            return TestMaximum(entry1, entry2, entry3);
        }
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
