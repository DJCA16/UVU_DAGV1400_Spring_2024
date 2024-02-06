using System;

namespace MyApplication
{
    public class Program
    {
        public static Intro mySentence;

        public static void Main(string [] args)
        {
            mySentence = new Intro();
            Console.Write(mySentence.myName + " , I am " + mySentence.myAge + " years old. ");
            mySentence.myAge++;
            Console.Write("I will be " + mySentence.myAge + " years old on " + mySentence.myBirthday + ".");
            Console.WriteLine(" This is my " + mySentence.myYear + " at " + mySentence.mySchool + ". ");
            Console.WriteLine("I work at " + mySentence.myWork + " where they pay me $" + mySentence.myWage +
                              " an hour.");
            Console.WriteLine("Would you like to do: 1.Addition 2.Subtraction 3.Multiplication 4.Division");
            Console.WriteLine("Enter 1/2/3/4: ");
            int operators = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter first number: ");
            int operand1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            int operand2 = Convert.ToInt32(Console.ReadLine());
            Variables(operators, operand1, operand2);
        }

        public static void Variables(int operators , int operand1, int operand2)
        {
            try
            {
                if (operators == 1)
                {
                    Console.WriteLine("Result of Addition: " + (operand1 + operand2));
                }
                else if (operators == 2)
                {
                    Console.WriteLine("Result of Subtraction: " + (operand1 - operand2));
                }
                else if (operators == 3)
                {
                    Console.WriteLine("Result of Multiplication: " + (operand1 * operand2));
                }
                else if (operators == 4)
                {
                    try
                    {
                        Console.WriteLine("Result of Division: " + (operand1 / operand2));
                    }
                    catch (DivideByZeroException )
                    {
                        Console.WriteLine("Error: Cannot divide by zero");
                    }
                }
            }
            catch
            {
                Console.WriteLine("You need to enter 1/2/3 or 4!!");
            }
        }
    }

    public class Intro
    {
        //used string for parts of my sentence, int for the whole number and decimal for the float while also keeping the 0 at the end
        public string myName = "My name is Dominic";
        public int myAge = 21;
        public string myBirthday = "February 16th";
        public decimal myWage = 19.50M;
        public string myWork = "Costco";
        public string myYear = "Freshman year";
        public string mySchool = "Utah Valley University";
    }
}

