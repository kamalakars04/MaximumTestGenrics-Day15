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

            // Calling the TestMaximum static method
            int maximum = MaximumTester.TestMaximum(15, 30, 45);
        }
    }
}
