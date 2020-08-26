using System;
using System.Linq;

namespace Ejercicio_15
{
    class Ejercicio15
    {
        
        static void Main()
        {
            //Inicializo el array.
            int[] arrayEntero1 = new int[50];
            int numero1;
            int constante1;
            int constante2; 
            Random rnd = new Random();
            for (int i = 0; i < 50; i++)
            {
                arrayEntero1[i] = rnd.Next(1, 50);
            }
            //Lo ordeno ascendentemente
            for(int i = 0; i < 50; i++)
            {
                for(int j = 0; j < 50; j++)
                {
                    if(arrayEntero1[j] > arrayEntero1[i])
                    {
                        numero1 = arrayEntero1[i];
                        arrayEntero1[i] = arrayEntero1[j];
                        arrayEntero1[j] = numero1;
                    }
                }
            }
            //Ingreso los limites de busqueda para listado de los elementos del array
            Console.Write("Ingrese el limite inferior de la busqueda: ");
            constante1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el limite superior de la busqueda: ");
            constante2 = int.Parse(Console.ReadLine());
            //Imprimo en la consola los elementos del arreglo que cumplan con la condicion dada.
            foreach(int numero in arrayEntero1)
            {
                if(numero > constante1 && numero < constante2)
                {
                    Console.WriteLine(numero);
                }
            }

        }
    }
}