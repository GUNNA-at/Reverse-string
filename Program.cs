using System;

class Program
{
    static void Main()
    {
        string original = "Andrii Kolodii";
        string reversed = ReverseString(original);
        Console.WriteLine($"original: {original}");
        Console.WriteLine($"reversed: {reversed}");
    }   
        public static string ReverseString(string input)

    {
        string reversed = string.Empty;
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }
        return reversed;

    }
}  
