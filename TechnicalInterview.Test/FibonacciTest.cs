using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class FibonacciTest
    {
        [TestMethod]
        public void Check_Generated_Nth_Term()
        {
            // Act
            var result = Fibonacci.ComputeNthFib(9);
            //Assert
            Assert.IsTrue(result == 21);
        }

        [TestMethod]
        public void Check_For_Negative_Nth_Term()
        {
            // Act
            var result = Fibonacci.ComputeNthFib(-10);
            //Assert
            Assert.IsTrue(result == -10);
        }

        [TestMethod]
        public void Check_For_Zero_Nth_Term()
        {
            // Act
            var result = Fibonacci.ComputeNthFib(0);
            //Assert
            Assert.IsTrue(result == 0);
        }
    }
}
