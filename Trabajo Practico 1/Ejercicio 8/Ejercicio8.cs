using System;

namespace Ejercicio_8
{
    class Ejercicio8
    { 
        static void Main()
        {
           
            Console.WriteLine("Ingrese la cantidad de numeros que desea calcular");
            int c = int.Parse(Console.ReadLine());
            int resultado;
            for(int a = 0; a <= c; a++)
            {
                resultado = Fibonacci(a);
                Console.WriteLine(resultado);
            }

        }
        static int Fibonacci(int n)
        {
            int x;
            if (n == 0)
            {
                x = 0;
                return (x);
            }
            else if (n == 1)
            {
                x = 1;
                return (x);
            }
            else
            {
                x = Fibonacci(n - 1) + Fibonacci(n - 2);
                return (x);
            }
        }
    }
}
