using System;
using System.Collections.Generic; // Necesario para usar List<T>

namespace ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear una lista de nombres
            List<string> nombres = new List<string>{"Ana", "Carlos", "Diana" };

            Console.WriteLine("Saludos: ");

            //Bucle foreach para iterar sobre cada nombre en la lista
            foreach (string xd in nombres) {
                Console.WriteLine("Hola, {0}!!", xd);
                    }
        }
    }
}


//Explicación del Código:
//Creación de la Lista:
//Se crea una lista de tipo string que contiene varios nombres. Esta lista se llama nombres.
//El Bucle foreach:
//Se declara un bucle foreach que toma cada string (cada nombre) de la lista nombres.
//Cuerpo del Bucle: Para cada nombre en la lista, el programa imprime un saludo personalizado.
//Ventajas del foreach
//Simplicidad: No necesitas manejar índices o preocuparte por los límites de la colección.
//Seguridad: Reduce el riesgo de errores, como acceder fuera de los límites de la colección.
//Legibilidad: Hace que el código sea más fácil de leer y mantener.
//El bucle foreach es ideal para situaciones donde necesitas acceder a cada elemento de una colección de forma secuencial y no necesitas modificar la colección mientras la iteras.

//Si tienes preguntas sobre este bucle o quieres explorar más ejemplos, detalles de otros bucles, o cualquier otro tema de programación, ¡sigue preguntando! Estoy aquí para ayudarte.