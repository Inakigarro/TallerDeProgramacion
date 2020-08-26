using System;

namespace Ejercicio_8
{
    class Ejercicio8
    { 
        static void Main()
        {
            //Ingreso por pantalla la cantidad de numeros de la serie de fibonacci que se desean calcular.
            Console.WriteLine("Ingrese la cantidad de numeros que desea calcular");
            int c = int.Parse(Console.ReadLine());
          
            for(int a = 0; a <= c; a++)
            {//Muestro en pantalla el numero perteneciente a la serie de fibonacci correspondiente al termino solicitado.
                Console.WriteLine("n = " + a + ", f(n) = " + Fibonacci(a));
            }

        }
        //Calculo recursivamente el termino de la serie de fibonacci correspondiente al argumento.
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
