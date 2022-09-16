using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class RomansNumeralTest
    {
        [TestMethod]
        public void Check_Generated_Romans_Numerals()
        {
            // Act
            var result = RomansNumeral.ConvertToRomansNumeral(135);
            //Assert
            Assert.IsTrue(result == "CXXXV");
        }

        [TestMethod]
        public void Check_For_Negative_Value()
        {
            // Act
            var result = RomansNumeral.ConvertToRomansNumeral(-8);
            //Assert
            Assert.IsTrue(result == "INVALID_INPUT");
        }

        [TestMethod]
        public void Check_For_Zero_Value()
        {
            // Act
            var result = RomansNumeral.ConvertToRomansNumeral(0);
            //Assert
            Assert.IsTrue(result == "INVALID_INPUT");
        }
    }
}
