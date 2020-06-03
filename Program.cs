
/* Directives are like imports 
 * System is a namespace
 */
using System;


namespace num_guesser
{
    class Program
    {
        private static Random random = new Random();
        static void Main(string[] args)
        {
            IntroMsg();
            int guesses = 10;
            while (guesses > 0)
            {
                int num = random.Next(10);
                PrintColorMsg(GetRandomConsoleColor(), "Guess a number btwn 1 and 10");
                string input = Console.ReadLine();

                if(!int.TryParse(input, out int number))
                {

                    PrintColorMsg(ConsoleColor.Red, "Please enter a number");
                    continue;
                }
                int userGuess = Int32.Parse(input);
                guesses--;

                if (num != userGuess)
                {
                    Console.ForegroundColor = GetRandomConsoleColor();
                    Console.WriteLine($"Wrong number :( {guesses} guesses remaining");
                }
                if (num == userGuess)
                {
                    PrintColorMsg(GetRandomConsoleColor(), "YOU WIN, Play again? Enter Y or N");
                    string response = Console.ReadLine().ToUpper();
                    if (response != "Y" || response == null)
                    {
                        break;
                    }

                }
            }
        static void IntroMsg()
        {
            Console.ForegroundColor = GetRandomConsoleColor();
            string appName = "Number Guesser";
            string version = "1.0.0";
            string author = "David Sanderson";

            Console.WriteLine("{0} author: {1} version: {2}", appName, author, version);
        }

        static ConsoleColor GetRandomConsoleColor()
            {
                var consoleColors = Enum.GetValues(typeof(ConsoleColor));
                return (ConsoleColor)consoleColors.GetValue(random.Next(consoleColors.Length));
            }
        }


        static void PrintColorMsg(ConsoleColor color, string msg)
        {
            Console.
                ForegroundColor = color;

            Console.WriteLine(msg);

            Console.ResetColor();
        }

    }
}
