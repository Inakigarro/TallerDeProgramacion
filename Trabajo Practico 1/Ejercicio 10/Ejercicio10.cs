using System;

namespace Ejercicio_10
{
    class Ejercicio10
    {
        static void Main()
        {
            //Entre los años 1900 y 2015
            for(int a = 1900; a <= 2015; a++)
            {//Si el año a es biciesto
                if (DateTime.IsLeapYear(a))
                {//Lo muestro en la consola.
                    Console.WriteLine("El año " + a + " es biciesto");
                }
            }
        }
    }
}
