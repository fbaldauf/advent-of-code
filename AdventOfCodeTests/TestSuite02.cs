using AdventOfCode._02;

namespace AdventOfCodeTests
{
    [TestClass]
    public class TestSuite02
    {
        [TestMethod]
        public void PossibleGameShouldReturnID()
        {
            var data = "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green";
            var actual = Challenge.ComputeLine(data);
            Assert.AreEqual(1, actual);
        }

        [TestMethod]
        public void ImPossibleGameShouldReturn0()
        {
            var data = "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red";
            var actual = Challenge.ComputeLine(data);
            Assert.AreEqual(0, actual);
        }
    }
}