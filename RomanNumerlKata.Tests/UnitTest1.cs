using NUnit.Framework;
using RomanNumeralKata.Source;

namespace RomanNumerlKata.Tests
{
    public class RomanNumeralShould
    {
        [TestCase(1,"I")]
        [TestCase(2,"II")]
        [TestCase(3,"III")]
        [TestCase(4,"IV")]
        [TestCase(5,"V")]
        [TestCase(6, "VI")]
        [TestCase(7, "VII")]
        [TestCase(8, "VIII")]
        [TestCase(9, "IX")]
        [TestCase(10,"X")]
        [TestCase(11, "XI")]
        [TestCase(12, "XII")]
        [TestCase(13, "XIII")]
        [TestCase(14, "XIV")]
        [TestCase(15, "XV")]
        [TestCase(16, "XVI")]
        [TestCase(500,"D")]
        [TestCase(50,"L")]
        [TestCase(100,"C")]
        [TestCase(1000,"M")]
       
        public void ReturnRoman_GivenArabic(int arabic, string expected)
        {
            var romanNumeral = new RomanNumeral();

            var result = romanNumeral.ToRoman(arabic);

            Assert.AreEqual(expected, result);
        }
        

    }
}