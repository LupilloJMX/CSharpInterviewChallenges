using System;

public class Program
{
    public static void Main(string[] args)
    {
        string text = "CsharpInterview";

        char masRepetido = ' ';
        int maxVeces = 0;

     
        for (int i = 0; i < text.Length; i++)
        {
            int count    = 0;

            for (int j = 0; j < text.Length; j++)
            {
                if (text[i] == text[j])
                    count++;
            }

            if (count > maxVeces)
            {
                maxVeces = count;
                masRepetido = text[i];
            }
        }

        Console.WriteLine($"Cadena: {text}");
        Console.WriteLine($"Caracter que más se repite: '{masRepetido}' ({maxVeces} veces)");


    }
}