using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GuessingGame1
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i=0; i<5;  i++)
            {
                DisplayGame();
            } 
        }

        static void DisplayGame()
        {
            int guess;
            string guessString;
            int min = 1;
            int max = 11;
            string result = null;

            Random ranNumberGenerator = new Random();
            int randomNumber;
            randomNumber = ranNumberGenerator.Next(min, max);

            Write("Choose a number between 1-10. ");
            guessString = ReadLine();
            guess = Convert.ToInt32(guessString);

            if (guess < max && guess >= min)
            {
                if (randomNumber == guess)
                {
                    result = " You win! You guessed " + randomNumber;
                }
                else if (guess > randomNumber)
                {
                    result = " You guessed too high ";
                }
                else if (guess < randomNumber)
                {
                    result = " You guessed too low ";
                }
            }
            else
            {
                result = " ERROR 404. You guessed outside of the range; " + min + " - " + max;
            }

            DisplayString(result);
        }
        static void DisplayString(string result)
        {
            WriteLine(result);
        }
    }
}
