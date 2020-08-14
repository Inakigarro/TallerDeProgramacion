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
            Console.WriteLine("Ingrese el limite inferior");
            int limiteInferior = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el limite superior");
            int limiteSuperior = int.Parse(Console.ReadLine());

            for(int num = limiteInferior; num <= limiteSuperior; num++ )
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
