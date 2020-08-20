using System;

namespace Ejercicio6
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {//Inicializo las variables necesarias para el ejercicio.
            int numero = 1;
            int resultadoImpar = 0;
            int cantidadNumerosImpar = 0;
            //Mientras el numero sea menor o igual a 100
            while(numero <= 100)
            {//Un numero es impar si al dividirlo por 2 el resto es distinto de cero.
                if ((numero % 2) != 0)
                { //Sumo cada numero impar encontrado a la variable resultado. Aumento la cantidad de numeros sumados.
                    resultadoImpar += numero;
                    cantidadNumerosImpar++;
                }
                //Incremento la variable numero
                numero++;
            }
            //Muestro los resultados.
            Console.WriteLine("La cantidad de numeros impares sumados es: " + cantidadNumerosImpar);
            Console.WriteLine("El resultado de la suma de numero impares es: " + resultadoImpar);
            Console.WriteLine("El promedio de la suma es: " + (resultadoImpar / cantidadNumerosImpar));
        }
    }
}
