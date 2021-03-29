using System;
using System.Collections.Generic;

namespace RomanNumeralKata.Source
{
    public class RomanNumeral
    {
        private readonly Dictionary<int, string> _arabicToRoman = new Dictionary<int, string>
        {
            {1000, "M"},
            {500, "D"},
            {100, "C"},
            {50, "L"},
            {10, "X"},
            {9, "IX"},
            {5, "V"},
            {4, "IV"},
            {1, "I"},
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
                    roman += _arabicToRoman[closestBiggestArabic];
                    while (remainder > 0)
                    {
                        foreach (var arabicKey in _arabicToRoman.Keys)
                        {
                            if (remainder >= arabicKey)
                            {
                                roman += _arabicToRoman[arabicKey];
                                remainder -= arabicKey;
                            }
                        }

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
                    roman += _arabicToRoman[closestBiggestArabic];
                    while (remainder > 0) 
                    {
                        foreach (var arabicKey in _arabicToRoman.Keys)
                        {
                            if (remainder >= arabicKey)
                            {
                                roman += _arabicToRoman[arabicKey];
                                remainder -= arabicKey;
                            }
                        }

                    }
                   

                    return roman;
                }
            }
           


            return roman;

        }
    }
}
