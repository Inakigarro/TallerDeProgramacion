using System;
using System.ComponentModel;

namespace Ejercicio_13
{
    class Ejercicio13
    {
        static void Main(string[] args)
        {
           foreach(string arg in args)
            {
                string cadenaInvertida = "";
                int posicion = 0;
                while (posicion < arg.Length)
                {
                    cadenaInvertida =  arg.Substring(posicion, 1) + cadenaInvertida;
                    posicion++;
                }
                Console.WriteLine("Para la cadena " + arg + " la cadena invertida es: " + cadenaInvertida); 
            }
        }
    }
}
