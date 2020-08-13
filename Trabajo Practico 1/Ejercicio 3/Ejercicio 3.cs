using System;

namespace Trabajo_Practico_1
{
    class Ejercicio3
    { 
        static void Main()
        {
            int cantidadNumeros = 0;
            int resultado = 0;
            int promedio;
            for(int num = 1; num <= 50; num++ )
            {
                resultado += num;
                cantidadNumeros++;
                
            }
            promedio = resultado / cantidadNumeros;
            Console.WriteLine("Se sumaron " + cantidadNumeros + " numeros");
            Console.WriteLine("El resultado es: " + resultado);
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
