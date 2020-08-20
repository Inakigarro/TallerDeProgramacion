using System;

namespace Trabajo_Practico_1
{
    class Ejercicio5
    {
        static void Main()
        {//Inicializo las variables necesarias para la solucion del ejercicio.
            int num = 1;
            int resultado = 0;
            int cantidadNumeros = 0;
            int promedio = 0;
            //Sumo el primer numero, incremento la variable en 1 y la cantidad de numeros sumados.
            do
            {
                resultado += num;
                cantidadNumeros++;
                num++;
                //Mientras el numero sea menor o igual a 50, se repetira este bucle.
            } while (num <= 50);
            //Al final, calculo el promedio y muestro los resultados.
            promedio = resultado / cantidadNumeros;
            Console.WriteLine("La cantidad de numeros sumados es: " + cantidadNumeros);
            Console.WriteLine("El resultado de la suma es: " + resultado);
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
