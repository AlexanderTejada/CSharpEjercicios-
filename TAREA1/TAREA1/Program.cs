using System.Reflection.Metadata;

namespace tarea1{
    class program
    {
        static void Main(string[] args)
        {
            // realizar un programa de computadora que haga el calculo
            // del area y perimetro de un recangulo

            // variables

            double altura, ancho, area, perimetro;

            // pedimos la altura y convertimos a tipo double

            Console.Write("dame la altura: ");

            altura = Convert.ToDouble(Console.ReadLine());

            //pedimos el ancho

            Console.Write("dame el ancho: ");

            ancho = Convert.ToDouble(Console.ReadLine());

            //calculamos area

            area= altura * ancho;

            // calcular perimetro

            perimetro = 2 * (altura * ancho);   

            //mostrar resultado pantalla
            
            Console.WriteLine("el resultado de area es: {0}", area);
            Console.WriteLine("el perimetro es: {0}", perimetro);
        }

    }
}