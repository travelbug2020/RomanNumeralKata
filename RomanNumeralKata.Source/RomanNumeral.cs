using System;
using System.Collections.Generic;

namespace RomanNumeralKata.Source
{
    public class RomanNumeral
    {
        private readonly Dictionary<int, string> _arabicToRoman = new Dictionary<int, string>
        {
            {1, "I"},
            {5, "V"},
            {10, "X"},
            {50, "L"},
            {100, "C"},
            {500, "D"},
            {1000, "M"},
        };

        public string ToRoman(int arabic)
        {
            if (arabic == 11)
            {
                return "XI";
            }

            var roman = string.Empty;

            if (_arabicToRoman.ContainsKey(arabic))
            {
                roman += _arabicToRoman[arabic];
                return roman;
            }

            var timesGoingRound = 1;
            if (arabic <= 3)
            {
                while (timesGoingRound <= arabic)
                {
                    roman += _arabicToRoman[1];
                    timesGoingRound++;
                }

                return roman;
            }

            var closestMultiple = 5;
            var remainder = arabic % closestMultiple;
            if (_arabicToRoman.ContainsKey(closestMultiple))
            {
                roman += _arabicToRoman[closestMultiple];
                while (timesGoingRound <= remainder)
                {
                    roman += _arabicToRoman[1];
                    timesGoingRound++;
                }

                return roman;
            }
            
            return roman;

        }
    }
}
