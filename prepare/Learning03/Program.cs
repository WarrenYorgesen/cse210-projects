using System;

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();
        Fraction fraction = new Fraction();
        int randomInt;
        for (int i = 1; i < 21; i++)
        {
            randomInt = random.Next(1, 100);
            fraction.SetTop(randomInt);
            randomInt = random.Next(1, 100);
            fraction.SetBottom(randomInt);

            Console.WriteLine($"Fraction {i}: string: {fraction.GetFractionString()} Number: {fraction.GetDecimalValue()}");
        }

    }
}