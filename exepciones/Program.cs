using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            // Intenta abrir un archivo y leer su contenido
            string content = File.ReadAllText("path_to_file.txt");
            Console.WriteLine(content);
        }
        catch (FileNotFoundException ex)
        {
            // Manejo específico de la excepción de archivo no encontrado
            Console.WriteLine("El archivo no fue encontrado: " + ex.Message);
        }
        catch (Exception ex)
        {
            // Manejo de cualquier otro tipo de excepción
            Console.WriteLine("Ocurrió un error: " + ex.Message);
        }
        finally
        {
            // Código que se ejecuta después de los bloques try y catch
            Console.WriteLine("Operación intentada.");
        }
    }
}
