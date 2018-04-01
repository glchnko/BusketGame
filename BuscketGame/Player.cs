using System;
using System.Collections.Generic;

namespace BuscketGame 
{
    
    public class PlayerRandom
    {
        int rangeMin;
        int rangeMax;
        //int guessNumber;

        public PlayerRandom(int min, int max)
        {
            if (min >= max)
            {
                throw new ArgumentException("max must be grater than min");
            }
            rangeMin = min;
            rangeMax = max + 1;
        }

        public int NextGuess()
        {
            Random rnd = new Random();
            //-----
            //int res;
            //res = rnd.Next(rangeMin, rangeMax);
            //return res;
            // -----
            //int res = rnd.Next(rangeMin, rangeMax);
            //return res; 

            return rnd.Next(rangeMin, rangeMax);        
        }

    }

    public class PlayerSequencial 
    {
        int rangeMin;
        int rangeMax;
        int guess;

        public PlayerSequencial(int min, int max) 
        {
            rangeMin = min;
            rangeMax = max;
            guess = min;
           
        }

        public int NextGuess()
        {
            if(guess > rangeMax) {
                throw new ApplicationException();
            }

            //int a = 1;
            // int b = a + 1;
            //a = a + 1;
            //a = a + 1;
            //a = a + 1;
            //a += 1;
            //a++;

            int res = guess;

            guess = guess + 1;

            return res;

         
            //return guess++;
        }
    }

    public class PlayerSmartRandom {

        int rangeMin;
        int rangeMax;
        List<int> guesses = new List<int>();

        public PlayerSmartRandom(int min, int max)
        {
            if (min >= max)
            {
                throw new ArgumentException("max must be grater than min");
            }
            rangeMin = min;
            rangeMax = max + 1;

        }

        public int NextGuess()
        {
            Random rnd = new Random();
            //-----
            int res;


            do
            {
                res = rnd.Next(rangeMin, rangeMax);

            }
            while (guesses.Contains(res));

            guesses.Add(res);

            return res;
        }
    }
}