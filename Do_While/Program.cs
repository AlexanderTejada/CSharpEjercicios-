using System;

namespace DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0; //acumulador de numeros
            int numero; //numeros que se iran ingresando hasta que el usuario escriba '0'
            Console.WriteLine("Ingrese número para sumar, Ingrese '0' para terminar.");

            do
            {
                numero = Convert.ToInt32(Console.ReadLine()); //Obtiene el numero del usuario
                suma += numero; //Suma el numero al total

                Console.WriteLine("suma parcial: {0}", suma); //Muestra la suma parcial

            } while (numero !=0); //Continúá hasta que el usuario ingrese '0'

            // Muestra la suma total después de salir del bucle 

            Console.WriteLine("La suma total es: {0}", suma);
        }
    }
}


//Explicación del Código:
//Inicialización de Variables:
//suma: Acumula la suma de los números ingresados.
//numero: Almacena cada número que el usuario ingresa.
//El Bucle do-while:
//Cuerpo del Bucle: Primero, el código dentro del do se ejecuta. El usuario ingresa un número, el programa lo suma al total acumulado y muestra la suma parcial.
//Condición: Después de ejecutar el cuerpo del bucle, se verifica si el número ingresado es 0. Si no lo es, el bucle se repite. Si es 0, el bucle termina.
//Finalización:
//Cuando el usuario ingresa 0, el bucle termina y el programa muestra la suma total de los números ingresados.
