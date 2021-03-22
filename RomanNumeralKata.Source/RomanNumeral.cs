using System;
using System.Collections.Generic;

namespace RomanNumeralKata.Source
{
    public class RomanNumeral
    {
        public string ToRoman(int arabic)
        {
            var arabicToRoman = new Dictionary<int,string>
            {
                {1,"I"},
            };
            var roman = string.Empty;
            var timesGoingRound = 1;
            while (timesGoingRound <=  arabic)
            {
                roman += arabicToRoman[1];
                timesGoingRound++;
            }
            return roman;
        }
    }
}
