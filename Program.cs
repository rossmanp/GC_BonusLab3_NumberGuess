using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Pete Rossman
//Grand Circus .NET Bootcamp Bonus Lab 3
// March 28, 2017
namespace GC_BonusLab3_NumberGuess
{
    //This program generates a random integer from 1 to 100
    //and then prompts the user to guess the integer.

    class Program
    {
        static void Main(string[] args)
        {
            bool letsPlay = true;
            //This loop runs the number guess program. 
            while (letsPlay)
            {
                bool wrongGuess = true;
                int myInt = 0;
                Random rnd = new Random();
                int computerInt = rnd.Next(1, 101);
                int tries = 0;
                Console.WriteLine("I'm thinking of a number from 1 to 100.");
                Console.WriteLine("What do you think it is: ");
                while (wrongGuess)
                {
                    //This do while loop ensures that an integer between 1 and 100
                    //is chosen; if one is not the loop runs again.
                    do
                    {
                        int.TryParse(Console.ReadLine(), out myInt);
                        if (myInt < 1 || myInt > 100)
                        {
                            Console.WriteLine("Your input is not an integer from 1 to 100!");
                        }
                    }
                    while (myInt < 1 || myInt > 100);

                    tries++;

                    //These conditionals guide the user's next guess.
                    //If the correct number is guessed, the loop is broken.

                    if (myInt == computerInt)
                    {
                        wrongGuess = false;
                    }
                    else if (myInt <= computerInt - 10)
                    {
                        Console.WriteLine("Way too low! Try a higher number: ");
                    }
                    else if (myInt <= computerInt)
                    {
                        Console.WriteLine("Too low; try a slightly higher number: ");
                    }
                    else if (myInt >= computerInt + 10)
                    {
                        Console.WriteLine("Way too high! Try a lower number: ");
                    }
                    else if (myInt >= computerInt)
                    {
                        Console.WriteLine("Too high; try a slightly lower number: ");
                    }

                }
                Console.WriteLine("There you go! You got my number in " + tries + " guesses.");

                //This loop runs until "y" or "n" is input. If "y" is input the first
                //while loop repeats, if "n" is input the program ends, and if neither "y"
                //or "n" is input the following loop repeats until acceptable input is obtained.

                bool replay = true;
                while (replay)
                {
                    Console.WriteLine("Play again? (y/n): ");
                    string playAgain = Console.ReadLine();
                    if (playAgain.ToLower() == "y")
                    {
                        replay = false;
                    }
                    else if (playAgain.ToLower() == "n")
                    {
                        replay = false;
                        letsPlay = false;
                    }
                    else
                    {
                        Console.WriteLine("You did not enter y or n, please try again.");
                    }
                }
            }
            Console.WriteLine("Goodbye!");
            Console.ReadLine();
        }
    }
}
