using System;

namespace Ejercicio_7
{
    class Ejercicio7
    {
        static void Main(string[] args)
        {
            //Ingreso la cantidad de terminos que se sumaran para aproximar el numero Pi
            Console.WriteLine("Cuantos terminos desea sumar?");
            int cantidadSumas = int.Parse(Console.ReadLine());

            //Inicializo las variables necesarias para el ejercicio.
            double resultado = 0;
            double aproximacionPorcentual;
            //Realizo la cantidad de sumas ingresadas para aproximar el numero Pi.
            for(int n = 0;  n <= cantidadSumas; n++)
            {
                resultado += Math.Pow(-1, n) / ((2 * n) + 1);
            }
            //Calculo y muestro los resultados.
            Console.WriteLine("El resultado de la suma de Leibniz es: " + resultado);
            aproximacionPorcentual = (resultado * 100) / Math.PI;
            Console.WriteLine("La aproximacion porcentual es: " + aproximacionPorcentual);

        }
    }
}
