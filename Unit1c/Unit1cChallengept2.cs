using System;

class partTwo
{
    public static void Main(string[] args)
    {
        string[] foods = new string[3];

        Console.WriteLine("Enter your three favorite foods: ");
        try
        {
            if (foods.Length == 3)
            {
                for (int i = 0; i < foods.Length; i++)
                {
                    foods[i] = Console.ReadLine();
                }

                for (int i = 0; i < foods.Length; i++)
                {
                    Console.WriteLine("I love " + foods[i] + "!");
                }
            }
        }
        catch
        {
            Console.WriteLine("Please enter just three foods.");
        }

        Console.ReadKey();
    }
}
