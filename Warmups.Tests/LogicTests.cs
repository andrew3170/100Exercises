using NUnit.Framework;
using NUnit.Framework.Constraints;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class LogicTests
    {
        [TestCase(30, false, false)]
        [TestCase(50, false, true)]
        [TestCase(70, true, true)]
        public void GreatPartyTest(int cigars, bool isWeekend, bool expected)
        {
            // arrange
            Logic obj = new Logic();

            // act
            bool actual = obj.GreatParty(cigars, isWeekend);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 10, 2)]
        [TestCase(5, 2, 0)]
        [TestCase(5, 5, 1)]
        public void CanHazTable(int yourStyle, int dateStyle, int expected)
        {
            Logic obj = new Logic();

            int actual = obj.CanHazTable(yourStyle, dateStyle);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(70, false, true)]
        [TestCase(95, false, false)]
        [TestCase(95, true, true)]
        public void PlayOutside(int temp, bool isSummer, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.PlayOutside(temp, isSummer);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(60, false, 0)]
        [TestCase(65, false, 1)]
        [TestCase(65, true, 0)]
        public void CaughtSpeeding(int speed, bool isBirthday, int expected)
        {
            Logic obj = new Logic();

            int actual = obj.CaughtSpeeding(speed, isBirthday);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, 4, 7)]
        [TestCase(9, 4, 20)]
        [TestCase(10, 11, 21)]
        public void SkipSum(int a, int b, int expected)
        {
            Logic obj = new Logic();

            int actual = obj.SkipSum(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, false, "7:00")]
        [TestCase(5, false, "7:00")]
        [TestCase(0, false, "10:00")]
        public void AlarmClock(int day, bool vacation, string expected)
        {
            Logic obj = new Logic();

            string actual = obj.AlarmClock(day, vacation);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(6, 4, true)]
        [TestCase(4, 5, false)]
        [TestCase(1, 5, true)]
        public void LoveSix(int a, int b, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.LoveSix(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, false, true)]
        [TestCase(11, false, false)]
        [TestCase(11, true, true)]
        public void InRange(int n, bool outsideMode, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.InRange(n, outsideMode);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(22, true)]
        [TestCase(23, true)]
        [TestCase(24, false)]
        public void SpecialEleven(int n, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.SpecialEleven(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(20, false)]
        [TestCase(21, true)]
        [TestCase(22, true)]
        public void Mod20(int n, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.Mod20(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(3, true)]
        [TestCase(10, true)]
        [TestCase(15, false)]
        public void Mod35(int n, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.Mod35(n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(false, false, false, true)]
        [TestCase(false, false, true, false)]
        [TestCase(true, false, false, false)]
        public void AnswerCell(bool isMorning, bool isMom, bool isAsleep, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.AnswerCell(isMorning, isMom, isAsleep);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 3, true)]
        [TestCase(3, 1, 2, true)]
        [TestCase(3, 2, 2, false)]
        public void TwoIsOne(int a, int b, int c, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.TwoIsOne(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(1, 2, 4, false, true)]
        [TestCase(1, 2, 1, false, false)]
        [TestCase(1, 1, 2, true, true)]
        public void AreInOrder(int a, int b, int c, bool bOk, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.AreInOrder(a, b, c, bOk);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 5, 11, false, true)]
        [TestCase(5, 7, 6, false, false)]
        [TestCase(5, 5, 7, true, true)]
        public void InOrderEqual(int a, int b, int c, bool equalOk, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.InOrderEqual(a, b, c, equalOk);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(23, 19, 13, true)]
        [TestCase(23, 19, 12, false)]
        [TestCase(23, 19, 3, true)]
        public void LastDigit(int a, int b, int c, bool expected)
        {
            Logic obj = new Logic();

            bool actual = obj.LastDigit(a, b, c);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(2, 3, true, 5)]
        [TestCase(3, 3, true, 7)]
        [TestCase(3, 3, false, 6)]
        public void RollDice(int die1, int die2, bool noDoubles, int expected)
        {
            Logic obj = new Logic();

            int actual = obj.RollDice(die1, die2, noDoubles);

            Assert.AreEqual(expected, actual);
        }
    }
}
