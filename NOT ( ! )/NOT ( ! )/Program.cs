using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Te gusta correr? (s/n): ");
        char gustaCorrer = char.Parse(Console.ReadLine());

        if (!(gustaCorrer == 's'))
        {
            Console.WriteLine("Entonces quizás prefieras otro tipo de ejercicio.");
        }
        else
        {
            Console.WriteLine("Genial, correr es un excelente ejercicio cardiovascular.");
        }
    }
}
