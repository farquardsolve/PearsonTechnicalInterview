using System;
using System.Collections.Generic;
using System.Text;

namespace TechnicalInterview
{
    public class CoinChange
    {
        public static int GenerateMinimunNumberOfChange(int money, int[] pennies)
        {
            var defaultReturn = -1;
            if (money <= 0)
                return defaultReturn;

            int[] changes = new int[money + 1];
            Array.Fill(changes, int.MaxValue);
            int currentNumberOfChange;
            changes[0] = 0;
            foreach (var coin in pennies)
            {
                for (int value = 0; value < changes.Length; value++)
                {
                    if(coin <= value)
                    {
                        currentNumberOfChange = (changes[value - coin] == Int32.MaxValue) ? changes[value - coin] : changes[value - coin] + 1;
                        changes[value] = Math.Min(changes[value], currentNumberOfChange);
                    }
                }
            }
            return changes[money] != Int32.MaxValue ? changes[money] : defaultReturn;
        }
    }
}
