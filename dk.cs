using System;
using System.Globalization;

public class Program
{
    public static SchoolSubjects schoolSubjects;
    
    public static void Main()
    {
        Console.WriteLine("What is the current temperature in degrees Celsius?: ");
        int temp = Convert.ToInt32(Console.ReadLine());
        Compare(temp);
        schoolSubjects = new SchoolSubjects();
        schoolSubjects.favorite_subject;
        schoolSubjects.school_class();
        //Console.WriteLine("What is your favorite school subject? Math, English, History, Gym, Science: ");
        //string subject = (Console.ReadLine());
        //School(subject);
        Console.WriteLine("What grade did you get on your" + subject + " exam?: ");
        int grade = Convert.ToInt32(Console.ReadLine());
        ExamGrade(grade);

    }

    public static void Compare(int temp)
    {
        if (temp < 0)
        {
            Console.WriteLine("I would recommend staying home or wearing a heavy coat if you must go out.");
        }
        else if (temp >= 0 && temp < 10)
        {
            Console.WriteLine("It's chilly! Make sure to wear some warm clothes!");
        }
        else if (temp >= 10 && temp < 20)
        {
            Console.WriteLine("It can be cold. I recommend wearing a light jacket or sweatshirt.");
        }
        else if (temp >= 20 && temp < 30)
        {
            Console.WriteLine("It should be a nice day out! Go for a walk or ride a bike if you can.");
        }
        else if (temp >= 30 && temp < 40)
        {
            Console.WriteLine(
                "Its pretty warm out. Make sure you are staying hydrated and dont stay in the sun too long");
        }
        else
        {
            Console.WriteLine("DONT GO OUT! YOU WILL BURN!");
        }

    }
}

public class SchoolSubjects{
    public enum Subjects {
        Math,
        English,
        History,
        Gym,
        Science
    }

    public static Subjects favorite_subject = School.Subjects;
    
    public static void school_class(string[] args) {
        Console.WriteLine("What is your favorite school subject? Math, English, History, Gym, Science: ");
        favorite_subject = Console.ReadLine(); 
        switch (favorite_subject)
        {
           case Subjects.Math:
               Console.WriteLine("Math");
               break;
           case Subjects.English:
               Console.WriteLine("English");
               break;
           case Subjects.History:
               Console.WriteLine("History");
               break;
           case Subjects.Gym:
               Console.WriteLine("Gym");
               break;
           case Subjects.Science:
               Console.WriteLine("Science");
               break;
           default:
               Console.WriteLine(favorite_subject + "is not an option. Please pick one of the five options.");
               break;
        }
        
    }

    public static void ExamGrade(int grade)
    {
        if (grade >= 90) {
            Console.WriteLine("You are doing a great job in" + subject + ". Keep it up!");
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