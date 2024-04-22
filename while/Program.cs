using System;

namespace Suma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int numero;
            Console.WriteLine("Ingrese numero para sumar. Ingrese '0' para terminar");

            //solicita numero hata que el usuario ingrese 0
            while ((numero = Convert.ToInt32(Console.ReadLine())) != 0) {
                suma += numero;
                Console.WriteLine("Suma parcial: {0}", suma);
            }

            //Mostrar la suma total despues de salir del bucle

            Console.WriteLine("La suma total es: {0}", suma);
        }
    }
}