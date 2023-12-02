namespace AdventOfCode._02
{
    public class Challenge
    {
        static int MAX_RED = 12;
        static int MAX_GREEN = 13;
        static int MAX_BLUE = 14;

        public static int Run(string[] lines)
        {
            // compute each line and calculate sum
            return lines.Aggregate(0, (acc, x) => acc + ComputeLine(x));
        }

        public static int ComputeLine(string line)
        {
            var game = new Game(line);

            return game.power;
        }
    }

    internal class Game
    {
        public int id = 0;
        public int blue = 0;
        public int green = 0;
        public int red = 0;
        public int power = 0;

        public Game(string def)
        {
            var (title, turnDefs) = def.Split(':') switch { [var v, var i] => (v, i), _ => default };
            id = int.Parse(title.Substring(5));

            var turns = turnDefs.Split(';').Select(x => new Turn(x));
            red = turns.Select(x => x.red).Max();
            green = turns.Select(x => x.green).Max();
            blue = turns.Select(x => x.blue).Max();

            power = red * green * blue;
        }
    }

    internal class Turn
    {
        public int blue = 0;
        public int green = 0;
        public int red = 0;

        public Turn(string def)
        {
            var picks = def.Split(',');
            foreach (var pick in picks)
            {
                var (amount, color) = pick.Trim().Split(' ') switch { [var v, var i] => (v, i), _ => default };
                if (color == "red")
                {
                    red = int.Parse(amount);
                }
                if (color == "green")
                {
                    green = int.Parse(amount);
                }
                if (color == "blue")
                {
                    blue = int.Parse(amount);
                }
            }
        }
    }
}
