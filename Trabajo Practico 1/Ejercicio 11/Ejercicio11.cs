using System;

namespace Ejercicio_11
{
    class Ejercicio11
    {
        static void Main()
        {//Ingreso por consola el radio del circulo
            Console.Write("Ingrese el radio del circulo: ");
            double radio = double.Parse(Console.ReadLine());
            //Calculo el area y el perimetro
            double areaCirculo = (Math.PI * Math.Pow(radio, 2));
            double perimetroCircunferencia = 2 * Math.PI * radio;
            //Muestro por pantalla los resultados.
            Console.WriteLine("El Area del circulo es: " + areaCirculo);
            Console.WriteLine("El perimetro de la circunferencia es: " + perimetroCircunferencia);
        }
    }
}
