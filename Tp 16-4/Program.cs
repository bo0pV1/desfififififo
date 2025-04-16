using System;
internal class Program
{
    private static void Main(string[] args)
    {
        string palabra;
        string palabrasinespacios = string.Empty;
        string palindromo = string.Empty;
        Console.WriteLine("Ingrese una palabra");
        palabra = Console.ReadLine();
        palabra = palabra.ToLower();
        for (int i = 0; i <= palabra.Length - 1; i++)
        {
            if (palabra[i] != ' ')
            {
                palabrasinespacios += palabra[i];
            }
        }
        for (int i = palabrasinespacios.Length - 1; i >= 0; i--)
        {
            palindromo += palabrasinespacios[i];
        }
        if (palabrasinespacios == palindromo)
        {
            Console.WriteLine("Es un palindromo");
        }
        else 
        {
            Console.WriteLine("No es un palindromo");
        }
        Console.ReadKey();
    }
}