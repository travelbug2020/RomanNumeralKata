using NUnit.Framework;
using RomanNumeralKata.Source;

namespace RomanNumerlKata.Tests
{
    public class RomanNumeralShould
    {
        [TestCase(1,"I")]
        [TestCase(2,"II")]
        [TestCase(3,"III")]
        public void ReturnRoman_GivenArabic(int arabic, string expected)
        {
            var romanNumeral = new RomanNumeral();

            var result = romanNumeral.ToRoman(arabic);

            Assert.AreEqual(expected, result);
        }
        

    }
}