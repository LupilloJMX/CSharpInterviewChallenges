using System;

public class Program
{
    public static void Main(string[] args)
    {
        int number = 12345;
        int reversed = 0;
        int temp = number;

        while (temp > 0)
        {

            reversed = reversed * 10 + (temp % 10);
            temp = temp / 10;
        }
        Console.WriteLine(number);
        Console.WriteLine(reversed);
    }
}