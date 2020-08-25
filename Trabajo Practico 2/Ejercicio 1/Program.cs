using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creo 2 puntos p1 y p2.
            Punto p1 = new Punto(9, 6);
            Punto p2 = new Punto(3.4, 2);
            //Le pido al punto 1 que calcule su distancia al punto 2.

            Console.WriteLine("La distancia del punto 1 al punto 2 es: " + p1.CalcularDistanciaDesde(p2));
        }
    }
}
