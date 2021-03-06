﻿using NUnit.Framework;
using Warmups.BLL;

namespace Warmups.Tests
{
    [TestFixture]
    public class LoopTests
    {
        [TestCase("Hi", 2, "HiHi")]
        [TestCase("Hi", 3, "HiHiHi")]
        [TestCase("Hi", 1, "Hi")]
        public void StringTimesTest(string str, int n, string expected)
        {
            // arrange
            Loops obj = new Loops();

            // act
            string actual = obj.StringTimes(str, n);

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestCase("Chocolate", 2, "ChoCho")]
        [TestCase("Chocolate", 3, "ChoChoCho")]
        [TestCase("Abc", 3, "AbcAbcAbc")]
        public void FrontTimes(string str, int n, string expected)
        {
            Loops obj = new Loops();

            string actual = obj.FrontTimes(str, n);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("abcxx", 1)]
        [TestCase("xxx", 2)]
        [TestCase("xxxx", 3)]
        public void CountXX(string str, int expected)
        {
            Loops obj = new Loops();

            int actual = obj.CountXX(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("axxbb", true)]
        [TestCase("axaxxax", false)]
        [TestCase("xxxxx", true)]
        public void DoubleX(string str, bool expected)
        {
            Loops obj = new Loops();

            bool actual = obj.DoubleX(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("Hello", "Hlo")]
        [TestCase("Hi", "H")]
        [TestCase("Heeololeo", "Hello")]
        public void EveryOther(string str, string expected)
        {
            Loops obj = new Loops();

            string actual = obj.EveryOther(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("Code", "CCoCodCode")]
        [TestCase("abc", "aababc")]
        [TestCase("ab", "aab")]
        public void StringSplosion(string str, string expected)
        {
            Loops obj = new Loops();

            string actual = obj.StringSplosion(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("hixxhi", 1)]
        [TestCase("xaxxaxaxx", 1)]
        [TestCase("axxxaaxx", 2)]
        public void CountLast2(string str, int expected)
        {
            Loops obj = new Loops();

            int actual = obj.CountLast2(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 9 }, 1)]
        [TestCase(new int[] { 1, 9, 9 }, 2)]
        [TestCase(new int[] { 1, 9, 9, 3, 9 }, 3)]
        public void Count9(int[] numbers, int expected)
        {
            Loops obj = new Loops();

            int actual = obj.Count9(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 9, 3, 4 }, true)]
        [TestCase(new int[] { 1, 2, 3, 4, 9 }, false)]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, false)]
        public void ArrayFront9(int[] numbers, bool expected)
        {
            Loops obj = new Loops();

            bool actual = obj.ArrayFront9(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 2, 3, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 4, 1 }, false)]
        [TestCase(new int[] { 1, 1, 2, 1, 2, 3 }, true)]
        public void Array123(int[] numbers, bool expected)
        {
            Loops obj = new Loops();

            bool actual = obj.Array123(numbers);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("xxcaazz", "xxbaaz", 3)]
        [TestCase("abc", "abc", 2)]
        [TestCase("abc", "axc", 0)]
        public void SubStringMatch(string a, string b, int expected)
        {
            Loops obj = new Loops();

            int actual = obj.SubStringMatch(a, b);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("xxHxix", "xHix")]
        [TestCase("abxxxcd", "abcd")]
        [TestCase("xabxxxcdx", "xabcdx")]
        public void StringX(string str, string expected)
        {
            Loops obj = new Loops();

            string actual = obj.StringX(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("kitten", "kien")]
        [TestCase("Chocolate", "Chole")]
        [TestCase("CodingHorror", "Congrr")]
        public void AltPairs(string str, string expected)
        {
            Loops obj = new Loops();

            string actual = obj.AltPairs(str);

            Assert.AreEqual(expected, actual);
        }

        [TestCase("yakpak", "pak")]
        [TestCase("pakyak", "pak")]
        [TestCase("yak123ya", "123ya")]
        public void DoNotYak(string str, string expected)
        {
            Loops obj = new Loops();
            string actual = obj.DoNotYak(str);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int [] {6, 6, 2}, 1)]
        [TestCase(new int[] {6, 6, 2, 6}, 1)]
        [TestCase(new int[] {6, 7, 2, 6}, 1)]
        public void Array667(int[] numbers, int expected)
        {
            Loops obj = new Loops();
            int actual = obj.Array667(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 1, 2, 2, 1 }, true)]
        [TestCase(new int[] { 1, 1, 2, 2, 2, 1 }, false)]
        [TestCase(new int[] { 1, 1, 1, 2, 2, 2, 1 }, false)]
        public void NoTriples(int[] numbers, bool expected)
        {
            Loops obj = new Loops();
            bool actual = obj.NoTriples(numbers);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[] { 1, 2, 7, 1 }, true)]
        [TestCase(new int[] { 1, 2, 8, 1 }, false)]
        [TestCase(new int[] { 2, 7, 1 }, false)]
        public void Pattern51(int[] numbers, bool expected)
        {
            Loops obj = new Loops();
            bool actual = obj.Pattern51(numbers);
            Assert.AreEqual(expected, actual);
        }
    }
}
