using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int playerGuess;
            string playerInput;
            bool isNumberGuessed = false;
            int theAnswer;

            Random rng = new Random();
            theAnswer = rng.Next(1, 21);

            do
            {
                Console.Write("Enter your guess: ");
                playerInput = Console.ReadLine();

                playerGuess = int.Parse(playerInput);

                if (playerGuess == theAnswer)
                {
                    Console.WriteLine("You got it!");
                    //if user guesses the number correctly
                    //isNumberGuessed is set to true
                    //establishing the condition that will exit the do while loop 
                    isNumberGuessed = true;
                }
                else
                {
                    if (playerGuess > theAnswer)
                    {
                        Console.WriteLine("Too high!");
                    }
                    else
                    {
                        Console.WriteLine("Too low!");
                    }
                }
                //while isNumberGuessed is false;
                //once Number guessed becomes true we will jump out of the loop 
            } while (!isNumberGuessed);
            Console.ReadLine();
        } 
    }
}
