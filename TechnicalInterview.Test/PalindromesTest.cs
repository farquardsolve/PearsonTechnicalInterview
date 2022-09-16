using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TechnicalInterview.Test
{
    [TestClass]
    public class PalindromesTest
    {
        [TestMethod]
        public void Check_Sentence_Is_Palindrome()
        {
            // Act
            var result = Palindromes.IsPalindrome("Able was I ere I saw Elba");
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_Word_Is_Palindrome()
        {
            // Act
            var result = Palindromes.IsPalindrome("Madam");
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_Number_String_Is_Palindrome()
        {
            // Act
            var result = Palindromes.IsPalindrome("2002");
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Check_Sentence_Is_Not_Palindrome()
        {
            // Act
            var result = Palindromes.IsPalindrome("a number that reads the same backward or forward");
            //Assert
            Assert.IsTrue(!result);
        }

        [TestMethod]
        public void Check_Word_Is_Not_Palindrome()
        {
            // Act
            var result = Palindromes.IsPalindrome("Papa");
            //Assert
            Assert.IsTrue(!result);
        }

        [TestMethod]
        public void Check_for_Invalid_Input()
        {
            // Act
            var result = Palindromes.IsPalindrome(null);
            //Assert
            Assert.IsTrue(!result);
        }
    }
}
