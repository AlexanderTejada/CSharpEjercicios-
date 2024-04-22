// Incluye las clases estándar del sistema, como Console, que se utiliza para la entrada/salida.
using System;

// Define un espacio de nombres para organizar clases relacionadas.
// Puedes cambiar 'MyApp' por cualquier otro nombre que se ajuste mejor a tu proyecto.
namespace MyApp
{
    // Define una clase llamada 'Program'.
    // 'internal' significa que la clase es accesible solo dentro de este ensamblado (proyecto).
    internal class Program
    {
        // Define el método 'Main' como el punto de entrada del programa.
        // 'static' significa que el método pertenece a la clase misma, no a una instancia de la clase.
        // 'void' significa que el método no devuelve ningún valor.
        static void Main(string[] args)
        {
            // Un bucle 'for' que inicia con i = 0, continúa mientras i <= 5, y aumenta i en 1 en cada iteración.
            for (int i = 0; i <= 5; i++)
            {
                // Imprime el valor de 'i' en la consola.
                // Cada valor de 'i' desde 0 hasta 5 se imprimirá en una nueva línea.
                Console.WriteLine(i);
            }
        }
    }
}
