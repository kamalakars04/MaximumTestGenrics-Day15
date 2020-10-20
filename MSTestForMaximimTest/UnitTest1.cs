using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaximumTest;

namespace MSTestForMaximimTest
{
    [TestClass]
    public class UnitTest1
    {
        /// <summary>
        /// TC 1.1 Maximum  number in first position.
        /// </summary>
        [TestMethod]
        public void MaximumNumberInFirstPosition()
        {
            // Act
            int expected = MaximumTester<int>.TestMaximum(500, 200, 100);

            // Assert
            Assert.AreEqual(expected, 500);
        }

        /// <summary>
        /// TC 1.2 Maximum  number in second position.
        /// </summary>
        [TestMethod]
        public void MaximumNumberInSecondPosition()
        {
            // Act
            int expected = MaximumTester<int>.TestMaximum(500, 1200, 100);

            // Assert
            Assert.AreEqual(expected, 1200);
        }

        /// <summary>
        /// TC 1.3 Maximum  number in third position.
        /// </summary>
        [TestMethod]
        public void MaximumNumberInThirdPosition()
        {
            // Act
            int expected = MaximumTester<int>.TestMaximum(500, 200, 1100);

            // Assert
            Assert.AreEqual(expected, 1100);
        }

        /// <summary>
        /// TC 2.1 Maximum  number in first position.
        /// </summary>
        [TestMethod]
        public void MaximumFloatInFirstPosition()
        {
            // Act
            float expected = MaximumTester<float>.TestMaximum(500.2f, 200.3f, 100.2f);

            // Assert
            Assert.AreEqual(expected, 500.2f);
        }

        /// <summary>
        /// TC 2.2 Maximum  number in second position.
        /// </summary>
        [TestMethod]
        public void MaximumFloatInSecondPosition()
        {
            // Act
            float expected = MaximumTester<float>.TestMaximum(500.2f, 2000.3f, 100.2f);

            // Assert
            Assert.AreEqual(expected, 2000.3f);
        }

        /// <summary>
        /// TC 2.3 Maximum  number in third position.
        /// </summary>
        [TestMethod]
        public void MaximumFloatInThirdPosition()
        {
            // Act
            float expected = MaximumTester<float>.TestMaximum(500.2f, 200.3f, 1000.2f);

            // Assert
            Assert.AreEqual(expected, 1000.2f);
        }

        /// <summary>
        /// TC 3.1 Maximum string in first position.
        /// </summary>
        [TestMethod]
        public void MaximumStringInFirstPosition()
        {
            // Act
            string expected = MaximumTester<string>.TestMaximum("Peach", "Banana", "Apple");

            // Assert
            Assert.AreEqual(expected, "Peach");
        }

        /// <summary>
        /// TC 3.2 Maximum  string in second position.
        /// </summary>
        [TestMethod]
        public void MaximumStringInSecondPosition()
        {
            // Act
            string expected = MaximumTester<string>.TestMaximum("Apple", "Peach", "Banana");

            // Assert
            Assert.AreEqual(expected, "Peach");
        }

        /// <summary>
        /// TC 3.3 Maximum string in third position.
        /// </summary>
        [TestMethod]
        public void MaximumStringInThirdPosition()
        {
            // Act
            string expected = MaximumTester<string>.TestMaximum("Apple", "Banana", "Peach");

            // Assert
            Assert.AreEqual(expected, "Peach");
        }
    }
}
