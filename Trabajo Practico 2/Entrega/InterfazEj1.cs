using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class InterfazEj1
    {
        FachadaEjercicio1 fachada = new FachadaEjercicio1();
        public void MenuPrincipal()
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
                    Console.Clear();
                    MenuPunto();
                break;
                case '2':
                    Console.Clear();
                    MenuTriangulo();
                break;
                case '3':
                    Console.Clear();
                    MenuCirculo();
                break;
                case '0':
                break;
            }
        }
        public void MenuPunto()
        {
            Console.WriteLine("--- Punto ---");
            Console.WriteLine("1 - Distancia entre dos puntos.");
            Console.WriteLine("2 - Volver al menu Principal.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir");
            Console.WriteLine("");
            Console.Write("Ingrese una opcion para continuar: ");
            char opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    Console.WriteLine("Ingrese las coordenadas del punto inicial.");
                    Console.Write("X: ");
                    double x1 = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    double y1 = double.Parse(Console.ReadLine());
                    Console.WriteLine("Ingrese las coordenadas del punto final.");
                    Console.Write("X: ");
                    double x2 = double.Parse(Console.ReadLine());
                    Console.Write("Y: ");
                    double y2 = double.Parse(Console.ReadLine());
                    double distanciaEntrePuntos = fachada.CalcularDistanciaEntrePuntos(x1, y1, x2, y2);
                    Console.WriteLine("La distancia entre los puntos es: " + distanciaEntrePuntos);
                break;
                case '2':
                    Console.Clear();
                    MenuPrincipal();
                break;
                case '0':
                break;

            }  
        }
        public void MenuTriangulo()
        {
            Console.WriteLine("Ingrese las Coordenadas del Primer Punto.");
            Console.Write("X: ");
            double trianguloX1 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double trianguloY1 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ingrese las Coordenadas del Segundo Punto.");
            Console.Write("X: ");
            double trianguloX2 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double trianguloY2 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("Ingrese las Coordenadas del Tercer Punto.");
            Console.Write("X: ");
            double trianguloX3 = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double trianguloY3 = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("¿Que desea hacer?");            
            Console.WriteLine("1 - Calcular el Area de un Triangulo.");
            Console.WriteLine("2 - Calcular el Perimetro de un Triangulo.");
            Console.WriteLine("3 - Volver al Menu Principal.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            Console.WriteLine("");
            Console.Write("Ingrese una opcion para continuar: ");
            char opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    double areaTriangulo = fachada.CalcularAreaDeUnTriangulo(trianguloX1, trianguloY1, trianguloX2, trianguloY2, trianguloX3, trianguloY3);
                    Console.WriteLine("El Area del Triangulo es: " + areaTriangulo);
                break;
                case '2':
                    double perimetroTriangulo = fachada.CalcularPerimetroDeUnTriangulo(trianguloX1, trianguloY1, trianguloX2, trianguloY2, trianguloX3, trianguloY3);
                    Console.WriteLine("El Perimetro del Triangulo es: " + perimetroTriangulo);
                break;
                case '3':
                    Console.Clear();
                    MenuPrincipal();
                break;
                case '0':
                break;
            }
        }
        public void MenuCirculo()
        {
            Console.WriteLine("Ingrese las Coordenadas del Centro del Circulo.");
            Console.Write("X: ");
            double centroX = double.Parse(Console.ReadLine());
            Console.Write("Y: ");
            double centroY = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.Write("Ingrese el Radio del Circulo: ");
            double radioCirculo = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1 - Calcular el Area de un Circulo.");
            Console.WriteLine("2 - Calcular el Perimetro de un Circulo.");
            Console.WriteLine("3 - Volver al Menu Principal.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            Console.WriteLine("");
            Console.Write("Ingrese una opcion para continuar: ");
            char opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    double areaCirculo = fachada.CalcularAreaDeUnCirculo(centroX, centroY, radioCirculo);
                    Console.WriteLine("El area del Circulo es: " + areaCirculo);
                break;
                case '2':
                    double perimetroCirculo = fachada.CalcularPerimetroCirculo(centroX, centroY, radioCirculo);
                    Console.WriteLine("El Perimetro del Circulo es: " + perimetroCirculo);
                break;
                case '3':
                    Console.Clear();
                    MenuPrincipal();
                break;
                case '0':
                break;
            }
        }
    }
}
