using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            //Guess Game!
            string secretWord = "Muchiri";
            string guess = " ";
            int guessCount = 0;
            int guessLimit = 3;
            bool outOfGuess = false;
            while (guess != secretWord && !outOfGuess)
            {
                if(guessLimit > guessCount)
                {
                    Console.Write("Enter the word: ");
                    guess = Console.ReadLine();
                    guessCount++;
                }
                else 
                {
                    outOfGuess = true;
                }
                

            }
            if (outOfGuess)
            {
                Console.Write("You lose!");
            }
            else
            {
                Console.WriteLine("You win!");
            }
                Console.ReadLine();
        }

    }
}
