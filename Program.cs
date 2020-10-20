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

            // Initialising MaximumTester object for int
            MaximumTester<int> maximumTesterInt = new MaximumTester<int>(15, 15, 45);
            maximumTesterInt.TestMaximum();

            // Initialising MaximumTester object for float
            MaximumTester<float> maximumTesterFloat = new MaximumTester<float>(15.52f, 30.25f, 17.24f);
            maximumTesterFloat.TestMaximum();

            // Initialising MaximumTester object for int
            MaximumTester<string> maximumTesterString = new MaximumTester<string>("Apple", "Peach", "Banana");
            maximumTesterString.TestMaximum();
        }
    }
}
