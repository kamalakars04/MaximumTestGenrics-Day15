namespace MaximumTest
{
    using System;

    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to TEST MAXIMUM program");

            // Calling the TestMaximum static method for integer
            int maximumInteger = MaximumTester.TestMaximumInteger(15, 30, 45);

            // Calling the TestMaximum static method for float
            float maximumFloat = MaximumTester.TestMaximumFloat(15.52f, 30.25f, 17.24f);

            // Calling the TestMaximum static method for string
            string maximumString = MaximumTester.TestMaximumString("Apple", "Peach", "Banana");
        }
    }
}
