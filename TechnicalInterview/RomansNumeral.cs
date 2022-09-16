using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TechnicalInterview
{
    public class RomansNumeral
    {
        private static Dictionary<string,int> romans = new Dictionary<string,int>() { 
            { "M",1000},
            {"CM",900},
            {"D",500},
            {"CD",400},
            {"C",100},
            {"XC",90},
            {"L",50},
            {"XL",40},
            {"X",10},
            {"IX",9},
            {"V",5},
            {"IV",4},
            {"I",1}};
        private static string invalidInput = "INVALID_INPUT";
        public static string ConvertToRomansNumeral(int number)
        {
            if (number > 3999 || number < 1) return invalidInput;
            
            var counter = 0;
            var stringBuilder = new StringBuilder();
            
            while (number > 0)
            {
                var numeralItem = romans.ElementAt(counter);
                if (number - numeralItem.Value >= 0)
                {
                    stringBuilder.Append(numeralItem.Key);
                    number -= numeralItem.Value;
                }
                else
                    counter++;
            }
            return stringBuilder.ToString();
        }
    }
}
