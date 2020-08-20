using System;

namespace Trabajo_Practico_1
{
    class Ejercicio1
    {
        static void Main()
        {

            ;
            int numero = int.Parse(Console.ReadLine());
            if(numero == 1)
            {
                Console.WriteLine("Uno");
            }
            else if(numero == 2)
            {
                Console.WriteLine("Dos");
            }
            else if (numero == 3)
            {
                Console.WriteLine("Tres");
            }
            else if (numero == 4)
            {
                Console.WriteLine("Cuatro");
            }
            else if (numero == 5)
            {
                Console.WriteLine("Cinco");
            }
            else if (numero == 6)
            {
                Console.WriteLine("Seis");
            }
            else if (numero == 7)
            {
                Console.WriteLine("Siete");
            }
            else if (numero == 8)
            {
                Console.WriteLine("Ocho");
            }
            else if (numero == 9)
            {
                Console.WriteLine("Nueve");
            }
            else if (numero > 9)
            {
                Console.WriteLine("Otro");
            }
        }
    }
}
