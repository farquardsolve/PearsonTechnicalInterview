using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalInterview
{
    public class Fibonacci
    {
        public static int ComputeNthFib(int n)
		{
			if (n < 1) return n;

			int[] currentTwoTerm = { 0, 1 };
			var i = 3;
			while (i <= n)
			{
				int nextNth = currentTwoTerm[0] + currentTwoTerm[1];
				currentTwoTerm[0] = currentTwoTerm[1];
				currentTwoTerm[1] = nextNth;
				i++;
			}
			if (n > 1) return currentTwoTerm[1];
			
			return currentTwoTerm[0];
		}
	}
}
