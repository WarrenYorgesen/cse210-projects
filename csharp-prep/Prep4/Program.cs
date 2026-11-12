using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberlist = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = 1;
        string text = "";

        while (number != 0)
        {
            Console.Write("Enter number: ");
            text = Console.ReadLine();
            number = int.Parse(text);
            if (number != 0)
            {
                numberlist.Add(number);
            }
        }
        int sum = 0;
        foreach (int num in numberlist)
        {
            sum += num;
        }

        Console.WriteLine($"The sum is: {sum}");
        float average = (float)sum / numberlist.Count;
        Console.WriteLine($"The average is: {average}");
        int largest_num = 0;
        foreach (int num in numberlist)
        {
            if (largest_num < num)
            {
                largest_num = num;
            }
        }

        Console.WriteLine($"The largest number is: {largest_num}");
        Console.WriteLine(numberlist);
    }
}