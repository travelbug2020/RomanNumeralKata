using System;
using System.Collections.Generic;

namespace RomanNumeralKata.Source
{
    public class RomanNumeral
    {
        private readonly Dictionary<int, string> _arabicToRoman = new Dictionary<int, string>
        {
            {1, "I"},
            {4, "IV"},
            {5, "V"},
            {9, "IX"},
            {10, "X"},
            {50, "L"},
            {100, "C"},
            {500, "D"},
            {1000, "M"},
        };

        public string ToRoman(int arabic)
        {
            var roman = string.Empty;

            if (_arabicToRoman.ContainsKey(arabic))
            {
                roman += _arabicToRoman[arabic];
                return roman;
            }

            if (arabic <= 3)
            {
                var closestBiggestArabic = 1;
                var remainder = arabic - closestBiggestArabic;
                if (_arabicToRoman.ContainsKey(closestBiggestArabic))
                {
                    var timesGoingRound = 1;
                    roman += _arabicToRoman[closestBiggestArabic];
                    while (timesGoingRound <= remainder)
                    {
                        roman += _arabicToRoman[1];
                        timesGoingRound++;
                    }
                    return roman;
                }

            }


            if (arabic <= 9)
            {
                var closestBiggestArabic = 5;
                var remainder = arabic - closestBiggestArabic;
                if (_arabicToRoman.ContainsKey(closestBiggestArabic))
                {
                    var timesGoingRound = 1;
                    roman += _arabicToRoman[closestBiggestArabic];
                    while (timesGoingRound <= remainder)
                    {
                        roman += _arabicToRoman[1];
                        timesGoingRound++;
                    }

                    return roman;
                }
            }

            if (arabic >= 10)
            {
                var closestBiggestArabic = 10;
                var remainder = arabic - closestBiggestArabic;

                if (_arabicToRoman.ContainsKey(closestBiggestArabic))
                {
                    var timesGoingRound = 1;
                    roman += _arabicToRoman[closestBiggestArabic];
                    if (_arabicToRoman.ContainsKey(remainder))
                    {
                        roman += _arabicToRoman[remainder];
                    }
                    else
                    {
                        while (timesGoingRound <= remainder)
                        {
                            roman += _arabicToRoman[1];
                            timesGoingRound++;
                        }
                    }

                    return roman;
                }
            }
           


            return roman;

        }
    }
}
