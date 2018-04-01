using System;

namespace BuscketGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter minValue = ");
            int minValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter maxValue = ");
            int maxValue = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter guessNumber = ");
            int guessNumber = Convert.ToInt32(Console.ReadLine());


            PlayerSequencial player1 = new PlayerSequencial(minValue, maxValue);
            PlayerRandom player2 = new PlayerRandom(minValue, maxValue);
            PlayerSmartRandom player3 = new PlayerSmartRandom(minValue, maxValue);
            int p1guess;
            int p2guess;
            int p3guess;
            do
            {
                p1guess = player1.NextGuess();
                Console.WriteLine("Player 1 (Seq) guess is: " + p1guess);
                p2guess = player2.NextGuess();
                Console.WriteLine("Player 2 (Rnd) guess is: " + p2guess);
                p3guess = player3.NextGuess();
                Console.WriteLine("Player 3 (SmartRnd) guess is: " + p3guess);

                if (p1guess == guessNumber)
                {
                    Console.WriteLine("PlayerRandom won!");
                    break;
                }
                else if (p2guess == guessNumber)
                {
                    Console.WriteLine("PlayerSequencial won!");
                    break;
                }
                else if (p3guess == guessNumber)
                {
                    Console.WriteLine("PlayerSmartRandom won!");
                    break;
                }
            }
            while (true);
          
        }

    }
}
