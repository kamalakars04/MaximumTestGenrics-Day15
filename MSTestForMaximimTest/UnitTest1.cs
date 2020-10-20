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
            int expected = MaximumTester.TestMaximum(500, 200, 100);

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
            int expected = MaximumTester.TestMaximum(500, 1200, 100);

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
            int expected = MaximumTester.TestMaximum(500, 200, 1100);

            // Assert
            Assert.AreEqual(expected, 1100);
        }
    }
}
