using System;

namespace Seccion3
{
    class Program 
    {
        static void Main(string[] args)
        {
            byte edad;
            bool licencia;

            Console.Write("¿Qué edad tienes?: ");
            edad = Convert.ToByte(Console.ReadLine()); 
            Console.Write("¿Tienes licencia de conducir?: ");
            licencia = Convert.ToBoolean(Console.ReadLine()); 

            if ((edad >= 18) && (licencia == true))
            {
                Console.WriteLine("puedes conducir");
            }
            else
            {
                Console.WriteLine("Lo siento, no puedes conducir");
            }
           
        }
    }
}
