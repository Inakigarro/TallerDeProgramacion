using System;

namespace Trabajo_Practico_1
{
    class Ejercicio3
    { 
        static void Main()
        {//Inicializo las variables necesarias para el ejercicio.
            int cantidadNumeros = 0;  
            int resultado = 0;
            int promedio;
            //Ingreso por pantalla el limite inferior y superior entre los cuales se realizara la suma.
            Console.WriteLine("Ingrese el limite inferior");
            int limiteInferior = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el limite superior");
            int limiteSuperior = int.Parse(Console.ReadLine());
            //Para cada numero que se encuentre en el intervalo de los limites inrgesados previamente
            for(int num = limiteInferior; num <= limiteSuperior; num++ )
            {//Sumo ese numero a la variable resultado e incremento la cantidad de numeros sumados
                resultado += num;
                cantidadNumeros++;
                
            }
            //Calculo el promedio y muestro por patanlla los resultados.
            promedio = resultado / cantidadNumeros;
            Console.WriteLine("Se sumaron " + cantidadNumeros + " numeros");
            Console.WriteLine("El resultado es: " + resultado);
            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
