using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalInterview
{
    public class Palindromes
    {
		public static bool IsPalindrome(string input)
		{
			if (string.IsNullOrEmpty(input)) return false;

			input = input.ToLower();
			int firstPointer = 0;
			int secondPointer = input.Length - 1;
			while (firstPointer < secondPointer)
			{
				if (input[firstPointer] != input[secondPointer]) return false;
				firstPointer++;
				secondPointer--;
			}
			return true;
		}
	}
}
