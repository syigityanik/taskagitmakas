using System;

namespace taşkağıtmakas
{
    class Program
    {
        static void Main(string[] args)
        {
            int game = 0;
            int A = 0;
            int B = 0;
            int tie = 0;

            while (game<100)
            {
                string[] choices = new string[3] { "ROCK", "PAPER", "SCISSOR" };
                Random rnd = new Random();
                int n = rnd.Next(0, 3);
                string user = choices[1];

               if (user == "PAPER" && choices[n] == "ROCK")
                {
                    A += 1;
                }
                else if (user == "PAPER" && choices[n] == "SCISSOR")
                {
                    B += 1;
                }
                else if (user == "PAPER" && choices[n] == "PAPER")
                {
                    tie++;
                }
                game++;
            }
            Console.WriteLine("Player A wins " + A + " of 100 games");
            Console.WriteLine("Player B wins " + B + " of 100 games");
            Console.WriteLine("Tie: " + tie + " of 100 games");
        }
    }
}