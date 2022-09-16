using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class MinimumNumberOfChangeTest
    {
        [TestMethod]
        public void Check_Returned_Number_of_Change()
        {
            // Act
            var penny = 39;
            var denominations = new int[] { 1, 2, 5, 10, 20, 50, 100 };
            var result = CoinChange.GenerateMinimunNumberOfChange(penny,denominations);
            //Assert
            Assert.IsTrue(result == 5);
        }
        [TestMethod]
        public void Check_Returned_Number_of_Change_For_Nagative_Value()
        {
            // Act
            var penny = -25;
            var denominations = new int[] { 1, 2, 5, 10, 20, 50, 100 };
            var result = CoinChange.GenerateMinimunNumberOfChange(penny, denominations);
            //Assert
            Assert.IsTrue(result == -1);
        }
        [TestMethod]
        public void Check_Returned_Number_of_Change_For_Zero_Value()
        {
            // Act
            var penny = 0;
            var pennies = new int[] { 1, 2, 5, 10, 20, 50, 100 };
            var result = CoinChange.GenerateMinimunNumberOfChange(penny, pennies);
            //Assert
            Assert.IsTrue(result == -1);
        }
        [TestMethod]
        public void Check_Valid_Pennies_Array_Input()
        {
            // Act
            var penny = 0;
            var pennies = new int[7];
            var result = CoinChange.GenerateMinimunNumberOfChange(penny, pennies);
            //Assert
            Assert.IsTrue(result == -1);
        }
    }
}
