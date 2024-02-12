using System;

class Unit1cChallengept1
{
    public static void Main(string[] args)
    {
        Random number = new Random();
        int randNum = number.Next(1, 11);
        bool success = false;
        while (success == false)
        {
            Console.WriteLine("Guess a number 1 though 10: ");
            int guessNum = Convert.ToInt32(Console.ReadLine());
            success = userGuess(randNum, guessNum);
        }
    }
    public static bool userGuess(int randNum, int guessNum)
    {
        bool guessedCorrectly = false;
        if (guessNum <= 10 && guessNum > 0)
        {
            if (guessNum > randNum)
            {
                Console.WriteLine("Your guess is too high. Guess again: ");
            }
            else if (guessNum < randNum)
            {
                Console.WriteLine("Your guess is too low. Guess again: ");
            }
            else if (guessNum == randNum)
            {
                guessedCorrectly = true;
                Console.WriteLine("Congrats!! You guessed correctly!");
            }
        }
        else
        {
            Console.WriteLine("Please enter a number between 1 and 10");
        }
        return guessedCorrectly;
    }
    
}