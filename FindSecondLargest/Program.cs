using System;

public class Program
{
    public static void Main(string[] args)
    {
        int[] numbers = { 5, 11, 1, 9, 3, 8, 4 };
        //output: 9
        Array.Sort(numbers);
        Array.Reverse(numbers);
       

        Console.WriteLine("Sorted array: " + string.Join(", ", numbers));

     
        int second = numbers[0];
        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] != numbers[0])
            {
                second = numbers[i];
                break;
            }
        }

        Console.WriteLine($"Second largest: {second}");
    }
}