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
            var roman = String.Empty;
            foreach (var arabicKey in _arabicToRoman.Keys)
            {
                var remainder = arabic - arabicKey; 
                while (remainder >= 0)
                {
                    roman += _arabicToRoman[arabicKey];
                    remainder -= arabicKey;
                    arabic -= arabicKey;
                }
            }
            return roman;
        }
    }
}
