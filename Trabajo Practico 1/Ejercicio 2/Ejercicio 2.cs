using System;

namespace Ejercicio_2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {

            string entradaSwitch = Console.ReadLine();
            int numero = int.Parse(entradaSwitch);
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
                default:
                    Console.WriteLine("OTRO");
                    break;

            }
        }
    }
}
