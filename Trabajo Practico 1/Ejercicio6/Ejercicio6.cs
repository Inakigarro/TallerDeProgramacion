using System;

namespace Ejercicio6
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            int numero = 1;
            int resultadoImpar = 0;
            int cantidadNumerosImpar = 0;
            while(numero < 100)
            {
                if ((numero % 2) != 0)
                {
                    resultadoImpar += numero;
                    cantidadNumerosImpar++;
                }
                numero++;
            }

            Console.WriteLine("La cantidad de numeros impares sumados es: " + cantidadNumerosImpar);
            Console.WriteLine("El resultado de la suma de numero impares es: " + resultadoImpar);
            Console.WriteLine("El promedio de la suma es: " + (resultadoImpar / cantidadNumerosImpar));
        }
    }
}
