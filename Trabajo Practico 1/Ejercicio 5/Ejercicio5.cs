using System;

namespace Trabajo_Practico_1
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            int num = 1;
            int resultado = 0;
            int cantidadNumeros = 0;
            int promedio = 0;
            do
            {
                resultado += num;
                cantidadNumeros++;
                num++;
            } while (num <= 50);
            Console.WriteLine("La cantidad de numeros sumados es: " + cantidadNumeros);
            Console.WriteLine("El resultado de la suma es: " + resultado);
            promedio = resultado / cantidadNumeros;
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
