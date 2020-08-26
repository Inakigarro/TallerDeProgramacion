using System;

namespace Ejercicio_9
{
    class Ejercicio9
    {
        static void Main()
        {
            //Inicializo la variable resultado
            int r = 0;
            //Para todo numero entero 35<= a <=1977.
            for (int a = 35; a <= 1977; a++)
            {//Todo numero es primo si solo es divisible por si mismo y por 1.
                if (((a % a) == 0) && ((a % 1) == 0))
                { //Si el resto de la division entre el numero en cuestion y los primeros numeros primos es distinto de cero, entonces este numero no es divisible por estos numeros.
                    if (((a % 2) != 0) && ((a % 3) != 0) && ((a % 5) != 0) && ((a % 7) != 0)) 
                    {//Imprimio por pantalla el numero primo encontrado y lo sumo a la variable r.
                        Console.WriteLine("Se ha sumado el numero + " + a + " a la variable r");
                        r += a;
                    }
                }
            }
            //Muestro el resultado final de la suma de todos los numeros primos encontrados y sumados
            Console.WriteLine("El resultado final es: " + r);
        }
    }
}
