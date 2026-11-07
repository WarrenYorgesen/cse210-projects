using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What percent was your grade? ");
        int number = int.Parse(Console.ReadLine());
        string grade = "";

        if (number >= 90)
        {
            grade = "A";
        }
        else if (number >= 80)
        {
            grade = "B";
        }
        else if (number >= 70)
        {
            grade = "C";
        }
        else if (number >= 60)
        {
            grade = "D";
        }
        else if (number < 60)
        {
            grade = "F";
        }

        Console.WriteLine($"Your grade is {grade}");

        if (number >= 70)
        {
            Console.WriteLine("Congratulations on passing the class!");
        }
        else
        {
            Console.WriteLine("You didn't pass this time, but keep striving and you'll do even better next time!");
        }
        
    }
}