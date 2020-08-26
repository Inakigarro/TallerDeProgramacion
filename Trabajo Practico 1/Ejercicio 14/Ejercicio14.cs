using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_14
{
    class Ejercicio14
    {
        static void Main()
        {
            double[] arregloDouble = new double[30];
            Random rnd = new Random();
            for (int i = 0; i < arregloDouble.Length; i++)
            {
                arregloDouble[i] = rnd.Next(1,100) + rnd.NextDouble();
            }

            double minimo = arregloDouble.Min();
            double maximo = arregloDouble.Max();
            double sumaTotal = 0;
            for (int i = 0; i < arregloDouble.Length; i++)
            {
                sumaTotal += arregloDouble[i];
            }
            double promedio = sumaTotal / arregloDouble.Length;
            Console.WriteLine("El minimo valor del arreglo es: " + minimo);
            Console.WriteLine("El maximo valor del arreglo es: " + maximo);
            Console.WriteLine("La suma de todos los elementos del arreglo es: " + sumaTotal);
            Console.WriteLine("El promedio de los valores del arreglo es: " + promedio);

          


        }
    }
}
