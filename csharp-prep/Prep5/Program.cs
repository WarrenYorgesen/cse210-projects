using System;
using System.Reflection;
using System.Security.Cryptography;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string username = PromptUserName();
        int favnumber = PromptUserNumber();

        int birthyear;
        PromtUserBirthYear(out birthyear);

        int squared_number = SquareNumber(favnumber);

        DisplayResult(username, birthyear, squared_number);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        return number;
    }
    static void PromtUserBirthYear(out int number)
    {
        Console.Write("Please enter the year you were born: ");
        number = int.Parse(Console.ReadLine());
    }
    static int SquareNumber(int number)
    {
        int squared_number = number * number;
        return squared_number;
    }
    static void DisplayResult(string username, int birthyear, int squared_number)
    {
        Console.WriteLine($"{username}, the square of your number is {squared_number}");
        int turningage = 2026 - birthyear;
        Console.WriteLine($"{username}, you will turn {turningage} this year.");
    }
}