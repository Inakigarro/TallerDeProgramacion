using System;

namespace Ejercicio_4
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            int cantidadNumeros = 1;
            int resultado = 0;
            int promedio;
            int num = 1;
            while (num <= 50)
            {
                resultado += num;
                cantidadNumeros++; 
            }
            promedio = cantidadNumeros / resultado;
            Console.WriteLine("La cantidad de numeros sumados es: " + cantidadNumeros);
            Console.WriteLine("El resultado de la suma es: " + resultado);
            Console.WriteLine("El promedio es: " + promedio);

        }
    }
}
