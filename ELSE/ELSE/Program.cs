using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Else
{
    class program
    {
        static void Main(string[] args)
        {
            //Variables
            byte edad;
            //pedir edad
            Console.WriteLine("¿Que edad tienes?: ");
            edad=Convert.ToByte(Console.ReadLine());
            if (edad >=18 ) {

                //Se ejecuta si la condicion es "true"

                Console.WriteLine("Eres mayor de edad");
                    }
            else
            {
                Console.WriteLine("eres menor de edad");
            }

        }
    }
}