namespace MSTestForMaximimTest
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MaximumTest;

    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.1 Maximum  number in first position.
        /// </summary>
        [TestMethod]
        public void MaximumNumberInFirstPosition()
        {
            // Arrange
            MaximumTester<int> maximumTesterInt = new MaximumTester<int>(500, 30, 45);

            // Act
            int expected = maximumTesterInt.TestMaximum();

            // Assert
            Assert.AreEqual(expected, 500);
        }

        /// <summary>
        /// TC 1.2 Maximum  number in second position.
        /// </summary>
        [TestMethod]
        public void MaximumNumberInSecondPosition()
        {
            // Arrange
            MaximumTester<int> maximumTesterInt = new MaximumTester<int>(5, 30, 5);

            // Act
            int expected = maximumTesterInt.TestMaximum();

            // Assert
            Assert.AreEqual(expected, 30);
        }

        /// <summary>
        /// TC 1.3 Maximum  number in third position.
        /// </summary>
        [TestMethod]
        public void MaximumNumberInThirdPosition()
        {
            // Arrange
            MaximumTester<int> maximumTesterInt = new MaximumTester<int>(5, 30, 500);

            // Act
            int expected = maximumTesterInt.TestMaximum();

            // Assert
            Assert.AreEqual(expected, 500);
        }

        /// <summary>
        /// TC 2.1 Maximum  number in first position.
        /// </summary>
        [TestMethod]
        public void MaximumFloatInFirstPosition()
        {
            // Arrange
            MaximumTester<float> maximumTesterFloat = new MaximumTester<float>(50.2f, 30.3f, 5.5f);

            // Act
            float expected = maximumTesterFloat.TestMaximum();

            // Assert
            Assert.AreEqual(expected, 50.2f);
        }

        /// <summary>
        /// TC 2.2 Maximum  number in second position.
        /// </summary>
        [TestMethod]
        public void MaximumFloatInSecondPosition()
        {
            // Arrange
            MaximumTester<float> maximumTesterFloat = new MaximumTester<float>(50.2f, 500.5f, 30.3f);

            // Act
            float expected = maximumTesterFloat.TestMaximum();

            // Assert
            Assert.AreEqual(expected, 500.5f);
        }

        /// <summary>
        /// TC 2.3 Maximum  number in third position.
        /// </summary>
        [TestMethod]
        public void MaximumFloatInThirdPosition()
        {
            // Arrange
            MaximumTester<float> maximumTesterFloat = new MaximumTester<float>(50.2f, 500.5f, 3000.3f);

            // Act
            float expected = maximumTesterFloat.TestMaximum();

            // Assert
            Assert.AreEqual(expected, 3000.3f);
        }

        /// <summary>
        /// TC 3.1 Maximum string in first position.
        /// </summary>
        [TestMethod]
        public void MaximumStringInFirstPosition()
        {
            // Arrange
            MaximumTester<string> maximumTesterString = new MaximumTester<string>("Peach", "Apple", "Banana");

            // Act
            string expected = maximumTesterString.TestMaximum();

            // Assert
            Assert.AreEqual(expected, "Peach");
        }

        /// <summary>
        /// TC 3.2 Maximum  string in second position.
        /// </summary>
        [TestMethod]
        public void MaximumStringInSecondPosition()
        {
            // Arrange
            MaximumTester<string> maximumTesterString = new MaximumTester<string>("Apple", "Peach", "Banana");

            // Act
            string expected = maximumTesterString.TestMaximum();

            // Assert
            Assert.AreEqual(expected, "Peach");
        }

        /// <summary>
        /// TC 3.3 Maximum string in third position.
        /// </summary>
        [TestMethod]
        public void MaximumStringInThirdPosition()
        {
            // Arrange
            MaximumTester<string> maximumTesterString = new MaximumTester<string>("Apple", "Banana", "Peach");

            // Act
            string expected = maximumTesterString.TestMaximum();

            // Assert
            Assert.AreEqual(expected, "Peach");
        }
    }
}
