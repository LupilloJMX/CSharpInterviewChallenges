using System;

public class Program
{
    public static void Main(string[] args)
    {
        string text = "csharpInterview";

        char firstLetter = char.ToUpper(text[0]);
        string result = firstLetter + text.Substring(1);

        Console.WriteLine($"Original: {text}");
        Console.WriteLine($"Capitalized: {result}");    
    }
}