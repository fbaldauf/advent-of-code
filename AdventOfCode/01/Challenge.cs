using System.Text.RegularExpressions;

namespace AdventOfCode._01
{
    public class Challenge
    {

        static readonly Dictionary<string, char> NumberMap = new() {
            { "one", '1' }, { "two", '2' }, { "three", '3' }, { "four", '4' }, { "five", '5' },
            { "six", '6' }, { "seven", '7' }, { "eight", '8' }, { "nine", '9' }, };

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
            var value = GetDigitsOfLine(line).First();
            return ConvertDigitItemToChar(value);
        }
        private static char getSecondDigit(string line)
        {
            var value = GetDigitsOfLine(line, true).Last();
            return ConvertDigitItemToChar(value);
        }

        private static IEnumerable<string> GetDigitsOfLine(string line, bool reverse = false)
        {
            var AllNumberWords = NumberMap.Keys;
            var Expression = string.Join("|", AllNumberWords.Select(x => "(" + x + ")"));

            RegexOptions options = reverse ? RegexOptions.RightToLeft : RegexOptions.None;
            var rx = new Regex(@"(\d|" + Expression + ")", options);
            MatchCollection matches = rx.Matches(line);

            var values = matches.Select(x => x.Value);

            if (reverse)
            {
                return values.Reverse();
            }
            return values;
        }

        private static char ConvertDigitItemToChar(string value)
        {
            if (value.Length == 1)
            {
                return value[0];
            }

            return NumberMap.GetValueOrDefault(value);
        }
    }
}
