using NUnit.Framework;
using RomanNumeralKata.Source;

namespace RomanNumerlKata.Tests
{
    public class RomanNumeralShould
    {
        [TestCase(1,"I")]
        [TestCase(2,"II")]
        [TestCase(3,"III")]
        [TestCase(5,"V")]
        [TestCase(10,"X")]
        [TestCase(500,"D")]
        [TestCase(6,"VI")]
        [TestCase(7,"VII")]
        [TestCase(8,"VIII")]
        [TestCase(11,"XI")]
        public void ReturnRoman_GivenArabic(int arabic, string expected)
        {
            var romanNumeral = new RomanNumeral();

            var result = romanNumeral.ToRoman(arabic);

            Assert.AreEqual(expected, result);
        }
        

    }
}