namespace MaximumTest
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class MaximumTester<T> where T : IComparable
    {
        private T[] entries;

        /// <summary>
        /// Initializes a new instance of the <see cref="MaximumTester{T}"/> class.
        /// </summary>
        /// <param name="entries">The entries.</param>
        public MaximumTester(T[] entries)
        {
            this.entries = entries;
        }

        /// <summary>
        /// Tests the maximum.
        /// </summary>
        /// <returns></returns>
        public T TestMaximum()
        {
            return TestMaximum(entries);
        }
        /// <summary>
        /// Tests the maximum.
        /// </summary>
        /// <param name="entry1">The entry1.</param>
        /// <param name="entry2">The entry2.</param>
        /// <param name="entry3">The entry3.</param>
        /// <returns></returns>
        private T TestMaximum(T[] entries)
        {
            Array.Sort(entries);
            PrintMax(entries[^1]);
            return entries[^1];
        }

        /// <summary>
        /// Prints the maximum.
        /// </summary>
        /// <param name="maxValue">The maximum value.</param>
        private void PrintMax(T maxValue)
        {
            Console.WriteLine("The maximum string is {0}", entries[^1]);
        }
    }
}
