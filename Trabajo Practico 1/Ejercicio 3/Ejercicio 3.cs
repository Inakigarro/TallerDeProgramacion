using System;

namespace EjTrabajo_Practico_1ercicio_3
{
    class Ejercicio3
    { 
        static void Main()
        {
            int resultado = 0;
            for(int num = 1; num < 50; num++ )
            {
                resultado += num;
            }
            Console.WriteLine("El resultado es: " + resultado);
        }
    }
}
