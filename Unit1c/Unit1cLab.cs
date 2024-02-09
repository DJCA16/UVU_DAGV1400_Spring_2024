using System;

class Lab
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows in the pyramid: ");
        int rows = int.Parse(Console.ReadLine());

        if (rows <= 0)
        {
            //ensure the number is not a negative
            Console.WriteLine("Please enter a positive number.");
            return;
        }
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 0; j < i; j++)
            {
                //use Console.Write() to make sure all index stay on the same line
                Console.Write(i);
            }
            //use Console.WriteLine() to create new line
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}