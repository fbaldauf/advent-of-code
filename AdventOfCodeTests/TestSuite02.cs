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

        [TestMethod]
        public void PossibleGameShouldReturnPower()
        {
            string[] data = [
                "Game 1: 3 blue, 4 red; 1 red, 2 green, 6 blue; 2 green",
                "Game 2: 1 blue, 2 green; 3 green, 4 blue, 1 red; 1 green, 1 blue",
                "Game 3: 8 green, 6 blue, 20 red; 5 blue, 4 red, 13 green; 5 green, 1 red",
                "Game 4: 1 green, 3 red, 6 blue; 3 green, 6 red; 3 green, 15 blue, 14 red",
                "Game 5: 6 red, 1 blue, 3 green; 2 blue, 1 red, 2 green",
            ];
            var actual = Challenge.Run(data);
            Assert.AreEqual(2286, actual);
        }
    }
}