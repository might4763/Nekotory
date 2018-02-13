using System;
using NUnit.Framework;
using Calculation2;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculater2.Test
{
    [TestFixture]
    public class UnitTest1
    {
        /*
        [Test]
        public void TestMethod1()
        {
            var example = new Example();
            var result = example.Add(1, 2);

            Assert.That(result, Is.EqualTo(3), "1 + 2 should be 3");
        }
        */
        [Test]
        public void NDPlusND()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "-6.3", "-9.8");
            Assert.That(result, Is.EqualTo("-16.1"), "-6.3 + -9.9 should be -16.1");
        }
        [Test]
        public void NDPlusNI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "-6.3", "-9");
            Assert.That(result, Is.EqualTo("-15.3"), "-6.3 + -9 should be -15.3");
        }
        [Test]
        public void NDPlusZI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "-6.3", "0");
            Assert.That(result, Is.EqualTo("-6.3"), "-6.3 + 0 should be -6.3");
        }
        [Test]
        public void NDPlusPI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "-6.3", "7");
            Assert.That(result, Is.EqualTo("0.7"), "-6.3 + 7 should be 0.7");
        }
        [Test]
        public void NDPlusPD()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "-6.3", "7.5");
            Assert.That(result, Is.EqualTo("1.2"), "-6.3 + 7.5 should be 1.2");
        }
        [Test]
        public void NDMinusND()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "-6.3", "-9.8");
            Assert.That(result, Is.EqualTo("3.5"), "-6.3 - -9.9 should be 3.5");
        }
        [Test]
        public void NDMinusNI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "-6.3", "-9");
            Assert.That(result, Is.EqualTo("2.7"), "-6.3 - -9 should be 2.7");
        }
        [Test]
        public void NDMinusZI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "-6.3", "0");
            Assert.That(result, Is.EqualTo("-6.3"), "-6.3 - 0 should be -6.3");
        }
        [Test]
        public void NDMinusPI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "-6.3", "7");
            Assert.That(result, Is.EqualTo("-13.3"), "-6.3 - 7 should be 13.3");
        }
        [Test]
        public void NDMinusPD()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "-6.3", "7.5");
            Assert.That(result, Is.EqualTo("-13.8"), "-6.3 - 7.5 should be -13.8");
        }
        [Test]
        public void NDMulND()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "-6.3", "-9.8");
            Assert.That(result, Is.EqualTo("61.74"), "-6.3 * -9.8 should be 61.74");
        }
        [Test]
        public void NDMulNI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "-6.3", "-9");
            Assert.That(result, Is.EqualTo("56.7"), "-6.3 * -9 should be 56.7");
        }
        [Test]
        public void NDMulZI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "-6.3", "0");
            Assert.That(result, Is.EqualTo("0"), "-6.3 * 0 should be 0");
        }
        [Test]
        public void NDMulPI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "-6.3", "7");
            Assert.That(result, Is.EqualTo("-44.1"), "-6.3 * 7 should be -44.1");
        }
        [Test]
        public void NDMulPD()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "-6.3", "7.5");
            Assert.That(result, Is.EqualTo("-47.25"), "-6.3 * 7.5 should be -47.25");
        }
        [Test]
        public void NDDivND()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "-5.5", "-1.1");
            Assert.That(result, Is.EqualTo("5"), "-5.5 / -1.1 should be 5");
        }
        [Test]
        public void NDDivNI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "-5.5", "-2");
            Assert.That(result, Is.EqualTo("2.75"), "-5.5 / -2 should be 2.75");
        }
        [Test]
        public void NDDivZI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "-5.5", "0");
            Assert.That(result, Is.EqualTo("Cant divide by zero"), "-5.5 / 0 'should be Cant divide by zero'");
        }
        [Test]
        public void NDDivPI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "-5.5", "4");
            Assert.That(result, Is.EqualTo("-1.375"), "-5.5 / 4 should be -1.375");
        }
        [Test]
        public void NDDivPD()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "-5.5", "0.5");
            Assert.That(result, Is.EqualTo("-11"), "-5.5 /0.5 should be -11");
        }
        [Test]
        public void NIPlusND()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "-4", "-2.5");
            Assert.That(result, Is.EqualTo("-6.5"), "-4 + -2.5 should be -6.5");
        }
        [Test]
        public void NIPlusNI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "-4", "-2");
            Assert.That(result, Is.EqualTo("-6"), "-4 + -2 should be -6");
        }
        [Test]
        public void NIPlusZI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "-4", "0");
            Assert.That(result, Is.EqualTo("-4"), "-4 + 0 should be -4");
        }
        [Test]
        public void NIPlusPI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "-4", "9");
            Assert.That(result, Is.EqualTo("5"), "-4 + 9 should be 5");
        }
        [Test]
        public void NIPlusPD()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "-4", "9.9");
            Assert.That(result, Is.EqualTo("5.9"), "-4 + 9.9 should be 5.9");
        }
        [Test]
        public void NIMinusND()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "-4", "-2.5");
            Assert.That(result, Is.EqualTo("-1.5"), "-4 - -2.5 should be -1.5");
        }
        [Test]
        public void NIMinusNI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "-4", "-2");
            Assert.That(result, Is.EqualTo("-2"), "-4 - -2 should be -2");
        }
        [Test]
        public void NIMinusZI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "-4", "0");
            Assert.That(result, Is.EqualTo("-4"), "-4 - 0 should be -4");
        }
        [Test]
        public void NIMinusPI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "-4", "9");
            Assert.That(result, Is.EqualTo("-13"), "-4 - 9 should be -13");
        }
        [Test]
        public void NIMinusPD()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "-4", "-9.9");
            Assert.That(result, Is.EqualTo("5.9"), "-4 - -9.9 should be -5.9");
        }
        [Test]
        public void NIMulND()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "-4", "-2.5");
            Assert.That(result, Is.EqualTo("10"), "-4 *-2.5 should be 10");
        }
        [Test]
        public void NIMulNI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "-4", "-2");
            Assert.That(result, Is.EqualTo("8"), "-4 *-2 should be 8");
        }
        [Test]
        public void NIMulZI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "-4", "0");
            Assert.That(result, Is.EqualTo("0"), "-4 *0 should be 0");
        }
        [Test]
        public void NIMulPI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "-4", "9");
            Assert.That(result, Is.EqualTo("-36"), "-4 *9 should be -36");
        }
        [Test]
        public void NIMulPD()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "-4", "9.9");
            Assert.That(result, Is.EqualTo("-39.6"), "-4 *9.9 should be -39.6");
        }
        [Test]
        public void NIDivND()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "-4", "-2.5");
            Assert.That(result, Is.EqualTo("1.6"), "-4 /-2.5 should be -1.6");
        }
        [Test]
        public void NIDivNI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "-4", "-2");
            Assert.That(result, Is.EqualTo("2"), "-4 /-2 should be 2");
        }
        [Test]
        public void NIDivZI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "-4", "0");
            Assert.That(result, Is.EqualTo("Cant divide by zero"), "-4 /0 should be 'Cant divide by zero'");
        }
        [Test]
        public void NIDivPI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "-4", "8");
            Assert.That(result, Is.EqualTo("-0.5"), "-4 /8 should be -0.5");
        }
        [Test]
        public void NIDivPD()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "-4", "2.5");
            Assert.That(result, Is.EqualTo("-1.6"), "-4 /2.5 should be -1.6");
        }
        [Test]
        public void ZIPlusND()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "0", "-3.7");
            Assert.That(result, Is.EqualTo("-3.7"), "0 + -3.7 should be -3.7");
        }
        [Test]
        public void ZIPlusNI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "0", "-3");
            Assert.That(result, Is.EqualTo("-3"), "0 + -3 should be -3");
        }
        [Test]
        public void ZIPlusZI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "0", "0");
            Assert.That(result, Is.EqualTo("0"), "0 + 0 should be 0");
        }
        [Test]
        public void ZIPlusPI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "0", "6");
            Assert.That(result, Is.EqualTo("6"), "0 + 6 should be 6");
        }
        [Test]
        public void ZIPlusPD()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "0", "6.8");
            Assert.That(result, Is.EqualTo("6.8"), "0 + 6.8 should be 6.8");
        }
        [Test]
        public void ZIMinusND()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "0", "-3.7");
            Assert.That(result, Is.EqualTo("3.7"), "0 - -3.7 should be 3.7");
        }
        [Test]
        public void ZIMinusNI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "0", "-3");
            Assert.That(result, Is.EqualTo("3"), "0 - 3 should be 3");
        }
        [Test]
        public void ZIMinusZI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "0", "0");
            Assert.That(result, Is.EqualTo("0"), "0 - 0 should be 0");
        }
        [Test]
        public void ZIMinusPI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "0", "6");
            Assert.That(result, Is.EqualTo("-6"), "0 - 6 should be -6");
        }
        [Test]
        public void ZIMinusPD()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "0", "6.8");
            Assert.That(result, Is.EqualTo("-6.8"), "0 - 6.8 should be -6.8");
        }
        [Test]
        public void ZIMulND()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "0", "-3.7");
            Assert.That(result, Is.EqualTo("0"), "0 * -3.7 should be 0");
        }
        [Test]
        public void ZIMulNI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "0", "-3");
            Assert.That(result, Is.EqualTo("0"), "0 * -3 should be 0");
        }
        [Test]
        public void ZIMulZI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "0", "0");
            Assert.That(result, Is.EqualTo("0"), "0 * 0 should be 0");
        }
        [Test]
        public void ZIMulPI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "0", "6");
            Assert.That(result, Is.EqualTo("0"), "0 * 6 should be 0");
        }
        [Test]
        public void ZIMulPD()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "0", "6.8");
            Assert.That(result, Is.EqualTo("0"), "0 * 6.8 should be 0");
        }
        [Test]
        public void ZIDivND()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "0", "-3.7");
            Assert.That(result, Is.EqualTo("0"), "0 / -3.7 should be 0");
        }
        [Test]
        public void ZIDivNI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "0", "-3");
            Assert.That(result, Is.EqualTo("0"), "0 / -3 should be 0");
        }
        [Test]
        public void ZIDivZI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "0", "0");
            Assert.That(result, Is.EqualTo("Result is undenfined"), "0 / 0 should be 'Result is undenfined'");
        }
        [Test]
        public void ZIDivPI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "0", "6");
            Assert.That(result, Is.EqualTo("0"), "0 / 6 should be 0");
        }
        [Test]
        public void ZIDivPD()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "0", "6.8");
            Assert.That(result, Is.EqualTo("0"), "0 / 6.8 should be 0");
        }
        [Test]
        public void PIPlusND()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "3", "-1.2");
            Assert.That(result, Is.EqualTo("1.8"), "3 + -1.2 should be 1.8");
        }
        [Test]
        public void PIPlusNI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "3", "-1");
            Assert.That(result, Is.EqualTo("2"), "3 + -1 should be 1");
        }
        [Test]
        public void PIPlusZI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "3", "0");
            Assert.That(result, Is.EqualTo("3"), "3 + 0 should be 3");
        }
        [Test]
        public void PIPlusPI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "3", "5");
            Assert.That(result, Is.EqualTo("8"), "3 + 5 should be 8");
        }
        [Test]
        public void PIPlusPD()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "3", "5.3");
            Assert.That(result, Is.EqualTo("8.3"), "3 + 5.3 should be 8.3");
        }
        [Test]
        public void PIMinusND()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "3", "-1.2");
            Assert.That(result, Is.EqualTo("4.2"), "3 - -1.2 should be 4.2");
        }
        [Test]
        public void PIMinusNI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "3", "-1");
            Assert.That(result, Is.EqualTo("4"), "3 - -1 should be 4");
        }
        [Test]
        public void PIMinusZI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "3", "0");
            Assert.That(result, Is.EqualTo("3"), "3 - 0 should be 3");
        }
        [Test]
        public void PIMinusPI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "3", "5");
            Assert.That(result, Is.EqualTo("-2"), "3 - 5 should be -2");
        }
        [Test]
        public void PIMinusPD()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "3", "5.3");
            Assert.That(result, Is.EqualTo("-2.3"), "3 - 5.3 should be -2.3");
        }
        [Test]
        public void PIMulND()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "3", "-1.2");
            Assert.That(result, Is.EqualTo("-3.6"), "3 * -1.2 should be -3.6");
        }
        [Test]
        public void PIMulNI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "3", "-1");
            Assert.That(result, Is.EqualTo("-3"), "3 * -1 should be -3");
        }
        [Test]
        public void PIMulZI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "3", "0");
            Assert.That(result, Is.EqualTo("0"), "3 * 0 should be 0");
        }
        [Test]
        public void PIMulPI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "3", "5");
            Assert.That(result, Is.EqualTo("15"), "3 * 5 should be 15");
        }
        [Test]
        public void PIMulPD()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "3", "5.3");
            Assert.That(result, Is.EqualTo("15.9"), "3 * 5.3 should be 15.9");
        }
        [Test]
        public void PIDivND()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "3", "-1.2");
            Assert.That(result, Is.EqualTo("-2.5"), "3 / -1.2 should be -2.5");
        }
        [Test]
        public void PIDivNI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "3", "-1");
            Assert.That(result, Is.EqualTo("-3"), "3 / -1 should be -3");
        }
        [Test]
        public void PIDivZI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "3", "0");
            Assert.That(result, Is.EqualTo("Cant divide by zero"), "3 / 0 should be 'Cant divide by zero'");
        }
        [Test]
        public void PIDivPI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "3", "5");
            Assert.That(result, Is.EqualTo("0.6"), "3 / 5 should be 0.6");
        }
        [Test]
        public void PIDivPD()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "9", "1.5");
            Assert.That(result, Is.EqualTo("6"), "9 / 1.5 should be 6");
        }
        [Test]
        public void PDPlusND()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "12.8", "-3.2");
            Assert.That(result, Is.EqualTo("9.6"), "12.8 + -3.2 should be 9.6");
        }
        [Test]
        public void PDPlusNI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "12.8", "-3");
            Assert.That(result, Is.EqualTo("9.8"), "12.8 + -3 should be 9.8");
        }
        [Test]
        public void PDPlusZI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "12.8", "0");
            Assert.That(result, Is.EqualTo("12.8"), "12.8 + 0 should be 12.8");
        }
        [Test]
        public void PDPlusPI()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "12.8", "2");
            Assert.That(result, Is.EqualTo("14.8"), "12.8 + 2 should be 14.8");
        }
        [Test]
        public void PDPlusPD()
        {
            Cal cal = new Cal();
            var result = cal.total(1, "12.8", "6.4");
            Assert.That(result, Is.EqualTo("19.2"), "12.8 + 6.4 should be 19.2");
        }
        [Test]
        public void PDMinusND()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "12.8", "-3.2");
            Assert.That(result, Is.EqualTo("16"), "12.8 - -3.2 should be 16");
        }
        [Test]
        public void PDMinusNI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "12.8", "-3");
            Assert.That(result, Is.EqualTo("15.8"), "12.8 - -3 should be 15.8");
        }
        [Test]
        public void PDMinusZI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "12.8", "0");
            Assert.That(result, Is.EqualTo("12.8"), "12.8 - 0 should be 12.8");
        }
        [Test]
        public void PDMinusPI()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "12.8", "2");
            Assert.That(result, Is.EqualTo("10.8"), "12.8 - 2 should be 10.8");
        }
        [Test]
        public void PDMinusPD()
        {
            Cal cal = new Cal();
            var result = cal.total(2, "12.8", "6.4");
            Assert.That(result, Is.EqualTo("6.4"), "12.8 - 6.4 should be 6.4");
        }
        [Test]
        public void PDMulND()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "12.8", "-3.2");
            Assert.That(result, Is.EqualTo("-40.96"), "12.8 * -3.2 should be -40.96");
        }
        [Test]
        public void PDMulNI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "12.8", "-3");
            Assert.That(result, Is.EqualTo("-38.4"), "12.8 * -3 should be -38.4");
        }
        [Test]
        public void PDMulZI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "12.8", "0");
            Assert.That(result, Is.EqualTo("0"), "12.8 * 0 should be 0");
        }
        [Test]
        public void PDMulPI()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "12.8", "2");
            Assert.That(result, Is.EqualTo("25.6"), "12.8 * 2 should be 25.6");
        }
        [Test]
        public void PDMulPD()
        {
            Cal cal = new Cal();
            var result = cal.total(3, "12.8", "6.4");
            Assert.That(result, Is.EqualTo("81.92"), "12.8 * 6.4 should be 81.92");
        }
        [Test]
        public void PDDivND()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "12.8", "-3.2");
            Assert.That(result, Is.EqualTo("-4"), "12.8 / -3.2 should be -4");
        }
        [Test]
        public void PDDivNI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "12.8", "-4");
            Assert.That(result, Is.EqualTo("-3.2"), "12.8 / -4 should be -3.2");
        }
        [Test]
        public void PDDivZI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "12.8", "0");
            Assert.That(result, Is.EqualTo("Cant divide by zero"), "12.8 / 0 should be 'Cant divide by zero'");
        }
        [Test]
        public void PDDivPI()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "12.8", "2");
            Assert.That(result, Is.EqualTo("6.4"), "12.8 / 2 should be 6.4");
        }
        [Test]
        public void PDDivPD()
        {
            Cal cal = new Cal();
            var result = cal.total(4, "12.8", "6.4");
            Assert.That(result, Is.EqualTo("2"), "12.8 / 6.4 should be 2");
        }
    }
}
