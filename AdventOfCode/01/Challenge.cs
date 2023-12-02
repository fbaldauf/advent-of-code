namespace AdventOfCode._01
{
    public class Challenge
    {
        public static int Run(string[] lines)
        {
            // compute each line and calculate sum
            return lines.Aggregate(0, (acc, x) => acc + ComputeLine(x));
        }

        public static int ComputeLine(string line)
        {
            var firstDigit = getFirstDigit(line);
            var secondDigit = getSecondDigit(line);

            return int.Parse(string.Concat(firstDigit, secondDigit));
        }

        private static char getFirstDigit(string line)
        {
            return line.ToCharArray().Where(char.IsDigit).First();
        }
        private static char getSecondDigit(string line)
        {
            return line.ToCharArray().Where(char.IsDigit).Last();
        }
    }
}
