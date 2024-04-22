.
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
class Program
{
    
    static void Main()
    {
        // Preguntamos al usuario que nos diga un número.
        Console.Write("Introduce un número para ver su tabla de multiplicar: ");
        int numero = Convert.ToInt32(Console.ReadLine()); // Guardamos el número que nos digan.

        // Damos un mensaje que dice de qué número será la tabla.
        Console.WriteLine("Tabla de multiplicar del {0}:", numero);

        // Ahora empezamos a contar desde 1 hasta 10 y hacemos las multiplicaciones.
        for (int i = 1; i <= 10; i++) // Esto es como decir: mientras i sea menor o igual a 10, sigue haciendo esto:
        {
            int producto = numero * i;  // Multiplicamos el número por i (que cambia de 1 a 10)
            Console.WriteLine("{0} x {1} = {2}", numero,i, producto); // Mostramos el resultado como "5 x 1 = 5"
        }
    }
}
//Explicación de Cada Parte:
//using System;: Esto es como decirle a nuestro programa que vamos a usar herramientas básicas que ya vienen con C#, como algo que necesitamos para mostrar mensajes o leer lo que el usuario escribe.

//class Program : Aquí estamos creando una caja que guarda todo nuestro código.La llamamos Program.
//static void Main(): Esta es como la llave que arranca nuestro programa. Aquí es donde comienza todo cuando corremos el programa.

//Pidiendo un número:
//Console.Write("Introduce un número para ver su tabla de multiplicar: ");: Esto es como decir "Escribe un número para mostrarte algo especial con ese número".
//int numero = Convert.ToInt32(Console.ReadLine());: Aquí guardamos el número que el usuario escribe para usarlo después.
//Mostrando la tabla de multiplicar:
//Console.WriteLine($"Tabla de multiplicar del {numero}:");: Esto es como poner un título que dice "Aquí viene la tabla de multiplicar del número que nos diste".
//Bucle for para hacer las multiplicaciones:
//for (int i = 1; i <= 10; i++): Esto es como un contador que empieza en 1 y va hasta 10. Cada vez que cuenta, hace algo.
//int producto = numero * i;: Aquí hacemos la multiplicación del número por el contador i.
//Console.WriteLine($"{numero} x {i} = {producto}");: Mostramos cada resultado de la multiplicación.