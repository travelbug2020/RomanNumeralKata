using System;
using System.Collections.Generic;

namespace RomanNumeralKata.Source
{
    public class RomanNumeral
    {
        public string ToRoman(int arabic)
        {

            var roman = string.Empty;
            var arabicToRoman = new Dictionary<int, string>
            {
                {1, "I"},
                {5, "V"},
                {10, "X"},
                {50, "L"},
                {100, "C"},
                {500, "D"},
                {1000, "M"},
            };

            if (ArabicToRomanContainsKey(arabic, arabicToRoman))
            {
                roman += arabicToRoman[arabic];
                return roman;
            }

            var timesGoingRound = 1;
            if (arabic <= 3)
            {
                return SingleNumeral(arabic, timesGoingRound, roman, arabicToRoman);
            }

            var closestMultiple = 5;
            var extraNumberToAdd = arabic % closestMultiple;
            if (ArabicToRomanContainsKey(closestMultiple, arabicToRoman))
            {
                roman += arabicToRoman[closestMultiple];
                return SingleNumeral(extraNumberToAdd, timesGoingRound, roman, arabicToRoman);
            }
            
            return roman;

        }

        private static string SingleNumeral(int arabic, int timesGoingRound, string roman, Dictionary<int, string> arabicToRoman)
        {
            while (timesGoingRound <= arabic)
            {
                roman += arabicToRoman[1];
                timesGoingRound++;
            }

            return roman;
        }

        private static bool ArabicToRomanContainsKey(int arabic, Dictionary<int, string> arabicToRoman)
        {
            return arabicToRoman.ContainsKey(arabic);
        }
    }
}
