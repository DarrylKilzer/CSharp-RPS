using System;

namespace rps
{
    public class Program
    {
        public enum RPSPlay { Rock, Paper, Scissors }
        public enum RPSPlayResult { Win, Lose, Draw }
        static void Main(string[] args)
        {
            Random rand = new Random();
            while (true)
            {
                int count = 0;
                Console.Write("Your play ({0}) (q to exit) : ", string.Join(", ", Enum.GetNames(typeof(RPSPlay))));
                var line = Console.ReadLine().ToLower();
                Console.Clear();
                if (line.Equals("q"))
                    return;
                RPSPlay play;
                if (!Enum.TryParse(line, true, out play))
                {
                    Console.WriteLine("Invalid Input");
                    continue;
                }
                RPSPlay comp = (RPSPlay)rand.Next(Enum.GetNames(typeof(RPSPlay)).Length);
                Console.WriteLine("You Played {0}", play);
                Console.WriteLine("Computer Played {0}", comp);
                System.Console.WriteLine((RPSPlayResult)((2 + play - comp) % 3) + "\n");
            }
        }
    }
}
