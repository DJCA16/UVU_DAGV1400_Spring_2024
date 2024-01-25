using System;

namespace MyApplication
{
  public class Program
  {
 	public Intro mySentence;
    
    public void Main()
    {
      mySentence = new Intro();
      Console.Write(mySentence.myName + " , I am " + mySentence.myAge + " years old. ");
      mySentence.myAge++;
		Console.Write("I will be " + mySentence.myAge + " years old on " + mySentence.myBirthday + ".");
		Console.WriteLine(" This is my " + mySentence.myYear + " at " + mySentence.mySchool + ". ");
		Console.WriteLine("I work at " + mySentence.myWork + " where they pay me $" + mySentence.myWage + " an hour.");
     }
  }
  public class Intro {
  	public string myName = "My name is Dominic";
    public int myAge = 21;
    public string myBirthday = "February 16th";
	public decimal myWage = 19.50M;
	public string myWork = "Costco";
	public string myYear = "Freshman year";
	public string mySchool = "Utah Valley University";
  }
}