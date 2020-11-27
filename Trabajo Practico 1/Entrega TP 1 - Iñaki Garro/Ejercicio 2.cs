using System;

namespace Trabajo_Practico_1
{
    class Ejercicio2
    {
        static void Main()
        {
            //Ingreso por pantalla el numero a controlar.
            int numero = int.Parse(Console.ReadLine());
            //Si el numero esta entre 1 y 9 inclusive devuelve una cadena indicando que numero se ingreso.
            switch (numero)
            {
                case 1:
                    Console.WriteLine("UNO");
                    break;
                case 2:
                    Console.WriteLine("DOS");
                    break;
                case 3:
                    Console.WriteLine("TRES");
                    break;
                case 4:
                    Console.WriteLine("CUATRO");
                    break;
                case 5:
                    Console.WriteLine("CINCO");
                    break;
                case 6:
                    Console.WriteLine("SEIS");
                    break;
                case 7:
                    Console.WriteLine("SIETE");
                    break;
                case 8:
                    Console.WriteLine("OCHO");
                    break;
                case 9:
                    Console.WriteLine("NUEVE");
                    break;
                //Si el numero no esta entre 1 y 9 deuvelve 'Otro'. 
                default:
                    Console.WriteLine("OTRO");
                    break;

            }
        }
    }
}
