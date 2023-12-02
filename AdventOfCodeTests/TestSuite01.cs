using AdventOfCode._01;

namespace AdventOfCodeTests
{
    [TestClass]
    public class TestSuite01
    {
        [TestMethod]
        public void CombineOfDigitAtStartAndEnd()
        {
            var actual = Challenge.ComputeLine("1abc2");
            Assert.AreEqual(12, actual);
        }

        [TestMethod]
        public void CombineOfDigitInMiddle()
        {
            var actual = Challenge.ComputeLine("pqr3stu8vwx");
            Assert.AreEqual(38, actual);
        }

        [TestMethod]
        public void CombineWithMoreThan2Digits()
        {
            var actual = Challenge.ComputeLine("a1b2c3d4e5f");
            Assert.AreEqual(15, actual);
        }

        [TestMethod]
        public void CombineWith1Digit()
        {
            var actual = Challenge.ComputeLine("treb7uchet");
            Assert.AreEqual(77, actual);
        }

        [TestMethod]
        public void SumAllLines()
        {
            string[] data = ["1abc2", "pqr3stu8vwx", "a1b2c3d4e5f", "treb7uchet"];
            var actual = Challenge.Run(data);
            Assert.AreEqual(142, actual);
        }

        [TestMethod]
        public void CombineWithWordsAtStartAndEnd()
        {
            var actual = Challenge.ComputeLine("two1nine");
            Assert.AreEqual(29, actual);
        }

        [TestMethod]
        public void CombineWithWords()
        {
            var actual = Challenge.ComputeLine("eightwothree");
            Assert.AreEqual(83, actual);
        }

        [TestMethod]
        public void CombineWithWordsInMiddle()
        {
            var actual = Challenge.ComputeLine("abcone2threexyz");
            Assert.AreEqual(13, actual);
        }

        [TestMethod]
        public void CombineWithMergedWords()
        {
            var actual = Challenge.ComputeLine("xtwone3four");
            Assert.AreEqual(24, actual);
        }

        [TestMethod]
        public void CombineWithWordsAndDigits()
        {
            var actual = Challenge.ComputeLine("4nineeightseven2");
            Assert.AreEqual(42, actual);
        }

        [TestMethod]
        public void CombineWithWordsAndDigitsAndOther()
        {
            var actual = Challenge.ComputeLine("zoneight234");
            Assert.AreEqual(14, actual);
        }

        [TestMethod]
        public void CombineWithWordsOver9()
        {
            var actual = Challenge.ComputeLine("7pqrstsixteen");
            Assert.AreEqual(76, actual);
        }

        [TestMethod]
        public void SumAllLines2()
        {
            string[] data = ["two1nine", "eightwothree", "abcone2threexyz", "xtwone3four", "4nineeightseven2", "zoneight234", "7pqrstsixteen"];
            var actual = Challenge.Run(data);
            Assert.AreEqual(281, actual);
        }

        [TestMethod]
        public void CombineWithMergedWords2()
        {
            var actual = Challenge.ComputeLine("2oneight");
            Assert.AreEqual(28, actual);
        }
    }
}