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
    }
}