using NUnit.Framework;
using NUnit.Framework.Constraints;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class ConditionalTests
    {
        [TestCase(true, true, true)]
        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        public void AreWeInTroubleTest(bool aSmile, bool bSmile, bool expected)
        {
            // arrange
            Conditionals obj = new Conditionals();

            // act
            bool actual = obj.AreWeInTrouble(aSmile, bSmile);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, true)]
        [TestCase(true, false, false)]
        [TestCase(false, true, false)]
        public void CanSleepIn(bool isWeekday, bool isVacation, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.CanSleepIn(isWeekday, isVacation);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3)]
        [TestCase(3, 2, 5)]
        [TestCase(2, 2, 8)]
        public void SumDouble(int a, int b, int expected)
        {
            Conditionals obj = new Conditionals();

            int actual = obj.SumDouble(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(23, 4)]
        [TestCase(10, 11)]
        [TestCase(21, 0)]
        public void Diff21(int n, int expected)
        {
            Conditionals obj = new Conditionals();

            int actual = obj.Diff21(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(true, 6, true)]
        [TestCase(true, 7, false)]
        [TestCase(false, 6, false)]
        public void ParrotTrouble(bool isTalking, int hour, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.ParrotTrouble(isTalking, hour);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(9, 10, true)]
        [TestCase(9, 9, false)]
        [TestCase(1, 9, true)]
        public void Makes10(int a, int b, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.Makes10(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(103, true)]
        [TestCase(90, true)]
        [TestCase(89, false)]
        public void NearHundred(int n, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.NearHundred(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, -1, false, true)]
        [TestCase(-1, 1, false, true)]
        [TestCase(-5, -5, true, true)]
        public void PosNeg(int a, int b, bool negative, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.PosNeg(a, b, negative);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("candy", "not candy")]
        [TestCase("x", "not x")]
        [TestCase("not bad", "not bad")]
        public void NotString(string s, string expected)
        {
            Conditionals obj = new Conditionals();

            string actual = obj.NotString(s);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("kitten", 1, "ktten")]
        [TestCase("kitten", 0, "itten")]
        [TestCase("kitten", 4, "kittn")]
        public void MissingChar(string str, int n, string expected)
        {
            Conditionals obj = new Conditionals();

            string actual = obj.MissingChar(str, n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("code", "eodc")]
        [TestCase("a", "a")]
        [TestCase("ab", "ba")]
        public void FrontBack(string str, string expected)
        {
            Conditionals obj = new Conditionals();

            string actual = obj.FrontBack(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("Microsoft", "MicMicMic")]
        [TestCase("Chocolate", "ChoChoCho")]
        [TestCase("at", "atatat")]
        public void Front3(string str, string expected)
        {
            Conditionals obj = new Conditionals();

            string actual = obj.Front3(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("cat", "tcatt")]
        [TestCase("Hello", "oHelloo")]
        [TestCase("a", "aaa")]
        public void BackAround(string str, string expected)
        {
            Conditionals obj = new Conditionals();

            string actual = obj.BackAround(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(8, false)]
        public void Multiple3or5(int number, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.Multiple3or5(number);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("hi there", true)]
        [TestCase("hi", true)]
        [TestCase("high up", false)]
        public void StartHi(string str, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.StartHi(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(120, -1, true)]
        [TestCase(-1, 120, true)]
        [TestCase(2, 120, false)]
        public void IcyHot(int temp1, int temp2, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.IcyHot(temp1, temp2);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(12, 99, true)]
        [TestCase(21, 12, true)]
        [TestCase(8, 99, false)]
        public void Between10and20(int a, int b, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.Between10and20(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, 20, 10, true)]
        [TestCase(20, 19, 10, true)]
        [TestCase(20, 10, 12, false)]
        public void HasTeen(int a, int b, int c, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.HasTeen(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(13, 99, true)]
        [TestCase(21, 19, true)]
        [TestCase(13, 13, false)]
        public void SoAlone(int a, int b, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.SoAlone(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("adelbc", "abc")]
        [TestCase("adelHello", "aHello")]
        [TestCase("adedbc", "adedbc")]
        public void RemoveDel(string str, string expected)
        {
            Conditionals obj = new Conditionals();

            string actual = obj.RemoveDel(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("mix snacks", true)]
        [TestCase("pix snacks", true)]
        [TestCase("piz snacks", false)]
        public void IxStart(string str, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.IxStart(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("ozymandias", "oz")]
        [TestCase("bzoo", "z")]
        [TestCase("oxx", "o")]
        public void StartOz(string str, string expected)
        {
            Conditionals obj = new Conditionals();

            string actual = obj.StartOz(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, 3)]
        [TestCase(1, 3, 2, 3)]
        [TestCase(3, 2, 1, 3)]
        public void Max(int a, int b, int c, int expected)
        {
            Conditionals obj = new Conditionals();

            int actual = obj.Max(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", true)]
        [TestCase("Heelle", true)]
        [TestCase("Heelele", false)]
        public void GotE(string str, bool expected)
        {
            Conditionals obj = new Conditionals();

            bool actual = obj.GotE(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "HeLLO")]
        [TestCase("hi there", "hi thERE")]
        [TestCase("hi", "HI")]
        public void EndUp(string str, string expected)
        {
            Conditionals obj = new Conditionals();

            string actual = obj.EndUp(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("Miracle", 2, "Mrce")]
        [TestCase("abcdefg", 2, "aceg")]
        [TestCase("abcdefg", 3, "adg")]
        public void EveryNth(string str, int n, string expected)
        {
            Conditionals obj = new Conditionals();

            string actual = obj.EveryNth(str, n);

            Assert.AreEqual(expected, actual);
        }
    }
}
