using System;
class Program
{
    static void Main()
    {
        Console.Write("Es hoy fin de semana? (s/n): ");
        char esFinDeSemana = char.Parse(Console.ReadLine());
        Console.Write("Estas de vacaopmes? (s/n): ");
        char tieneVacaciones = char.Parse(Console.ReadLine());

        if (esFinDeSemana == 's' || tieneVacaciones == 's')
        {
            Console.WriteLine("Puedes relajarte hoy.");

        }
        else
        {
            Console.WriteLine("quiero que trabajes hoy.");
        }
    }
}