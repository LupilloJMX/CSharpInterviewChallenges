using System;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int n = int.Parse(Console.ReadLine());

        if (n < 0) n = n * -1;

        int count = 1;
        if (n == 0) count = 1;
        else
        {
            count = 0;
            while (n > 0)
            {
                n = n / 10;
                count++;
            }
        }

        Console.WriteLine($"Digits: {count}");
    }
}