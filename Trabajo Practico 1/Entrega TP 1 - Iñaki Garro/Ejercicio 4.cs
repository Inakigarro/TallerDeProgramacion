using System;

namespace Trabajo_Practico_1
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {//Inicializo las variables necesarias para el ejercicio.
            int cantidadNumeros = 0;
            int resultado = 0;
            int promedio;
            int num = 1;
            //Mientras el numero sea menor o igual a 50.
            while (num <= 50)
            {//Sumo el numero a la variable resultado. Incremento el numero y aumento en 1 la cantidad de numeros sumados.
                resultado += num;
                num++;
                cantidadNumeros++; 
            }
            //Calculo el promedio y muestro los resultados.
            promedio = resultado / cantidadNumeros;
            Console.WriteLine("La cantidad de numeros sumados es: " + cantidadNumeros);
            Console.WriteLine("El resultado de la suma es: " + resultado);
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
