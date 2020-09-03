using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Ejercicio_1
{
    class Ejercicio1
    {
        static void MenuTextoForma()
        {
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1 - Calcular Area.");
            Console.WriteLine("2 - Clacular Perimetro.");
            Console.WriteLine("3 - Volver al Menu Princiapl.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            Console.Write("Ingrese la opcion deseada: ");
        }
        static void MenuForma(Circulo pCirculo)
        {
            MenuTextoForma();
            char opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    Console.WriteLine("El area del Circulo es: " + pCirculo.Area());
                    Console.WriteLine("");
                    MenuForma(pCirculo);
                    break;
                case '2':
                    Console.WriteLine("El perimetro del Circulo es: " + pCirculo.Perimetro());
                    Console.WriteLine("");
                    MenuForma(pCirculo);
                    break;
                case '3':
                    MenuPrincipal();
                    break;
                case '0':
                    break;
            }
        }
        static void MenuForma(Triangulo pTriangulo)
        {
            MenuTextoForma();
            char opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    Console.WriteLine("El area del Triangulo es: " + pTriangulo.Area());
                    Console.WriteLine("");
                    MenuForma(pTriangulo);
                    break;
                case '2':
                    Console.WriteLine("El perimetro del Triangulo es: " + pTriangulo.Perimetro());
                    Console.WriteLine("");
                    MenuForma(pTriangulo);
                    break;
                case '3':
                    MenuPrincipal();
                    break;
                case '0':
                    break;
            }
        }
        static void MenuPunto(Punto pPunto)
        {
            double pX;
            double pY;
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1 - Calcular distancia entre puntos.");
            Console.WriteLine("2 - Volver al Menu Principal.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir");
            Console.Write("Ingrese la opcion deseada: ");
            char opcion = Convert.ToChar(Console.ReadLine());
            switch(opcion)
            {
                case '1':
                    Console.WriteLine("Ingrese las coordenadas del punto final");
                    Console.Write("X: ");
                    pX = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    pY = double.Parse(Console.ReadLine());
                    Console.WriteLine("");
                    Console.WriteLine("La distancia al punto (" + pX + ", " + pY + ") desde el punto (" + pPunto.X + ", " + pPunto.Y + ") es: " + pPunto.Distancia(pX, pY));
                    Console.WriteLine("");
                    MenuPunto(pPunto);
                    break;
                case '2':
                    MenuPrincipal();
                    break;
                case '0':
                    break;
            }
        }
        static void MenuPrincipal()
        {
            Console.WriteLine("1 - Puntos.");
            Console.WriteLine("2 - Triangulos.");
            Console.WriteLine("3 - Circulos.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            char opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    Console.WriteLine("Ingrese las coordanas del punto inicial.");
                    Console.Write("X: ");
                    double pX = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    double pY = double.Parse(Console.ReadLine());
                    Punto pPunto = new Punto(pX, pY);
                    Console.WriteLine("");
                    MenuPunto(pPunto);
                    break;
                case '2':
                    Console.WriteLine("Ingrese los puntos del triangulo.");
                    Console.WriteLine("Punto 1");
                    Console.Write("X: ");
                    double pX1 = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    double pY1 = double.Parse(Console.ReadLine());
                    Punto pPunto1 = new Punto(pX1, pY1);
                    Console.WriteLine("");
                    Console.WriteLine("Punto 2");
                    Console.Write("X: ");
                    double pX2 = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");                    
                    double pY2 = double.Parse(Console.ReadLine());
                    Punto pPunto2 = new Punto(pX2, pY2);
                    Console.WriteLine("");
                    Console.WriteLine("Punto 3");
                    Console.Write("X: ");
                    double pX3 = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    double pY3 = double.Parse(Console.ReadLine());
                    Punto pPunto3 = new Punto(pX3, pY3);
                    Triangulo pTriangulo = new Triangulo(pPunto1, pPunto2, pPunto3);
                    Console.WriteLine("");
                    MenuForma(pTriangulo);
                    break;
                case '3':
                    Console.WriteLine("Ingrese las coordenadas del centro del circulo");
                    Console.Write("X: ");
                    double pXc = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    double pYc = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese la longitud del radio del circulo.");
                    double radio = double.Parse(Console.ReadLine());
                    Circulo pCirculo = new Circulo(pXc, pYc, radio);
                    Console.WriteLine("");
                    MenuForma(pCirculo);
                    break;
                case '0':
                    break;
            }

        }
        static void Main()
        {
            MenuPrincipal();
        }
    }
}
