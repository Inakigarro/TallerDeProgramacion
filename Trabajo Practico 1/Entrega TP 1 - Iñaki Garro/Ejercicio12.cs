using System;

namespace Ejercicio_12
{
    class Ejercicio12
    {
        static int Factorial(int n)
        {//Calculo de forma recursiva el factorial de un numero n.
            int x;
            if (n == 0)
            {
                x = 1;
                return (x);
            }
            else
            {
                x = Factorial(n - 1) * n;
                return (x);
            }
           
        }
        static void Main(string[] args)
        {
            //Ingreso el numero al que quiero calcularle el factorial.
            Console.Write("Ingrese un numero entero: ");
            int numero = int.Parse(Console.ReadLine());
            int factorial = Factorial(numero);
            Console.WriteLine("El factorial de " + numero + " es: " + factorial);
            
        }
    }
}
