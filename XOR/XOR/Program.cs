using System;

class Program
{
    static void Main()
    {
        Console.Write("¿Es fin de semana? (sí/no): ");
        bool esFinDeSemana = Console.ReadLine().Trim().ToLower() == "sí";  //trim elimina espacios y tolower hace que el texto esté´en minusculas
        Console.Write("¿Estás trabajando? (sí/no): ");
        bool estasTrabajando = Console.ReadLine().Trim().ToLower() == "sí";  

        if (esFinDeSemana ^ estasTrabajando)  
        {
            Console.WriteLine("La condición XOR es verdadera: solo una de las afirmaciones es verdadera.");
        }
        else
        {
            Console.WriteLine("La condición XOR es falsa: ambas afirmaciones son verdaderas o ambas son falsas.");
        }
    }
}
