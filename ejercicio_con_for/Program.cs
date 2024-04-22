using System;


//Solicitar al Usuario un Número: Pediremos al usuario que introduzca un número n.
//Usar un Bucle for para Sumar los Números: Utilizaremos un bucle for para iterar desde 1 hasta n, sumando cada número a un acumulador.
//Imprimir cada Suma Parcial: En cada iteración del bucle, imprimir la suma parcial para que el usuario pueda ver cómo se acumula la suma.

class Program
{
    static void Main()
    {
        // Solicitar al usuario que introduzca un número
        Console.Write("Introduce un número para sumar desde 1 hasta n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int suma = 0; // Inicializar la suma en 0

        // Bucle for para sumar desde 1 hasta n
        for (int i = 1; i <= n; i++)
        {
            suma += i;  // Sumar i al acumulador suma
            Console.WriteLine($"Suma parcial ({i}): {suma}"); // Imprimir la suma parcial
        }

        // Imprimir la suma total
        Console.WriteLine($"La suma total de los números del 1 al {n} es: {suma}");
    }
}
