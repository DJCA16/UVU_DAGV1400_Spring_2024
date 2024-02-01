using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("What is the current temperature in degrees Celsius?: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        Compare(temp);
        Console.WriteLine("What grade did you get on your exam?: ");
        int grade = Convert.ToInt32(Console.ReadLine());
        ExamGrade(grade);

    }

    public static void Compare(int temp)
    {
        if (temp > 30)
        {
            Console.WriteLine("Make sure to stay hydrated and dont stay in the sun too long!");
        }
        else
        {
            Console.WriteLine("Its a nice day out. Enjoy the great weather!");
        }
    }

    public static void ExamGrade(int grade)
    {
        if (grade >= 90) {
            Console.WriteLine("You have an A!");
        }
        else if (grade >= 80 && grade <= 89)
        {
            Console.WriteLine("You have a B!");
        }else if (grade >= 70 && grade <= 79)
        {
            Console.WriteLine("You have a C!");
        }else if (grade >= 60 && grade <= 69)
        {
            Console.WriteLine("You have a D!");
        }else
        {
            Console.WriteLine("You have an F");
        }
        

    }
}    
