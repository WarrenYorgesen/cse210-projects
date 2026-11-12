using System;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {
        Random randomgenerator = new Random();
        int answer = randomgenerator.Next(1, 101);
        int guess = 0;
        while (guess != answer)
        {
            Console.Write("What is your guess? ");
            string string_guess = Console.ReadLine();
            guess = int.Parse(string_guess);
            if (guess > answer)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < answer)
            {
                Console.WriteLine("Higher");
            }
        }
        Console.Write("Correct!");
    }
}