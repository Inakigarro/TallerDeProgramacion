using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Ejercicio_1
{
    class Ejercicio1
    {
        private static void MenuPunto()
        {
            //Declaro las variables a utilizar para este metodo.
            double xA;
            double yA;
            double xB;
            double yB;
            Punto A;
            Punto B;

            //Mini Menu para la opcion 1 - Punto.
            Console.Clear();
            Console.WriteLine(" --- Punto ---");
            Console.WriteLine(" ");
            Console.WriteLine("1 - Distancia entre dos puntos.");
            Console.WriteLine("2 - Volver al menu principal.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            Console.WriteLine(" ");
            Console.Write("Ingrese la opcion deseada: ");
            char opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case '1':
                    //Ingresamos los datos del punto A.
                    Console.WriteLine(" --- Distancia entre dos puntos ---");
                    Console.WriteLine(" ");
                    Console.WriteLine("Ingrese los datos del punto A: ");
                    Console.Write("Coordenada x del punto A: ");
                    xA = double.Parse(Console.ReadLine());
                    Console.Write("Coordenada y del punto A: ");
                    yA = double.Parse(Console.ReadLine());
                    A = new Punto(xA, yA);

                    Console.WriteLine(" ");
                    //Ingresamos los datos del punto B.
                    Console.WriteLine("Ingrese los datos del punto B: ");
                    Console.Write("Coordenada x del punto B: ");
                    xB = double.Parse(Console.ReadLine());
                    Console.Write("Coordenada y del punto B: ");
                    yB = double.Parse(Console.ReadLine());
                    B = new Punto(xB, yB);
                    Console.Clear();

                    //Resultados del ingreso de datos.
                    Console.WriteLine(" --- Distancia entre dos puntos ---");
                    Console.WriteLine("Los puntos ingresados para trabajar son: ");
                    Console.WriteLine("* Punto A: (" + A.GetX() + " , " + A.GetY() + ")");
                    Console.WriteLine("* Punto B: (" + B.GetX() + " , " + B.GetY() + ")");
                    //Calculo de la distancia entre los puntos.
                    Console.WriteLine("La distancia entre los puntos ingresados es: " + A.CalcularDistanciaDesde(B));
                    Console.WriteLine(" ");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    break;
                case '2':
                    MenuInicial();
                    break;
                case '0':
                    break;
            }
            //Repetir, Volver al menu principal o salir.
            Console.Clear();
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1 - Ingresar puntos nuevos.");
            Console.WriteLine("2 - Volver al menu principal.");
            Console.WriteLine(" ");
            Console.WriteLine("0 - Salir.");
            Console.WriteLine(" ");
            Console.Write("Ingrese una opcion para continuar: ");
            opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    MenuPunto();
                    break;
                case '2':
                    MenuInicial();
                    break;
                case '0':
                    break;
            }
        }

        private static void MenuTriangulo()
        {
            //Declaro las variables a utilizar en este metodo.
            double xA;
            double yA;
            double xB;
            double yB;
            double xC;
            double yC;
            Punto A;
            Punto B;
            Punto C;
            Triangulo T;

            //Menu para la opcion 2 - Triangulo.
            Console.Clear();
            Console.WriteLine("¿Que desea hacere?");
            Console.WriteLine("1 - Area de un Triangulo.");
            Console.WriteLine("2 - Perimetro de un Triangulo.");
            Console.WriteLine("3 - Volver al menu principal.");
            Console.WriteLine(" ");
            Console.WriteLine("0 - Salir.");
            Console.Write("Ingrese la opcion deseada: ");
            char opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case '1':
                    //Menu Area de un Triangulo.
                    Console.Clear();
                    Console.WriteLine(" --- Area de un Triangulo ---");
                    Console.WriteLine(" ");

                    //Ingreso de datos del triangulo
                    Console.WriteLine("Ingrese los datos del Triangulo");
                    Console.WriteLine("Coordenadas del punto A: "); //Coordenadas del punto A
                    Console.Write("x: ");
                    xA = double.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    yA = double.Parse(Console.ReadLine());
                    A = new Punto(xA, yA);
                    Console.WriteLine(" ");
                    Console.WriteLine("Coordenadas del punto B: "); //Coordenadas del punto B
                    Console.Write("x: ");
                    xB = double.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    yB = double.Parse(Console.ReadLine());
                    B = new Punto(xB, yB);
                    Console.WriteLine("Coordenadas del punto C: "); //Coordenadas del punto C
                    Console.Write("x: ");
                    xC = double.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    yC = double.Parse(Console.ReadLine());
                    C = new Punto(xC, yC);

                    //Definicion final del punto.
                    Console.Clear();
                    Console.WriteLine("Los puntos que definen al triangulo son: ");
                    Console.WriteLine("* Punto A: ( " + A.GetX() + " , " + A.GetY() + " )"); //Punto A
                    Console.WriteLine("* Punto B: ( " + B.GetX() + " , " + B.GetY() + " )"); //Punto B
                    Console.WriteLine("* Punto C: ( " + C.GetX() + " , " + C.GetY() + " )"); //Punto C
                    T = new Triangulo(A, B, C);

                    Console.WriteLine(" ");
                    Console.WriteLine("El area del triangulo es: " + T.CalcularArea());
                    Console.WriteLine(" ");
                    Console.Write("Presione una tecla para continuar.");
                    Console.ReadKey();
                    MenuTriangulo();
                    break;
                case '2':
                    //Menu Area de un Triangulo.
                    Console.Clear();
                    Console.WriteLine(" --- Perimetro de un Triangulo ---");
                    Console.WriteLine(" ");

                    //Ingreso de datos del triangulo
                    Console.WriteLine("Ingrese los datos del Triangulo");
                    Console.WriteLine("Coordenadas del punto A: "); //Coordenadas del punto A
                    Console.Write("x: ");
                    xA = double.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    yA = double.Parse(Console.ReadLine());
                    A = new Punto(xA, yA);
                    Console.WriteLine(" ");
                    Console.WriteLine("Coordenadas del punto B: "); //Coordenadas del punto B
                    Console.Write("x: ");
                    xB = double.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    yB = double.Parse(Console.ReadLine());
                    B = new Punto(xB, yB);
                    Console.WriteLine("Coordenadas del punto C: "); //Coordenadas del punto C
                    Console.Write("x: ");
                    xC = double.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    yC = double.Parse(Console.ReadLine());
                    C = new Punto(xC, yC);

                    //Definicion final del Triangulo.
                    Console.Clear();
                    Console.WriteLine("Los puntos que definen al triangulo son: ");
                    Console.WriteLine("* Punto A: ( " + A.GetX() + " , " + A.GetY() + " )"); //Punto A
                    Console.WriteLine("* Punto B: ( " + B.GetX() + " , " + B.GetY() + " )"); //Punto B
                    Console.WriteLine("* Punto C: ( " + C.GetX() + " , " + C.GetY() + " )"); //Punto C
                    T = new Triangulo(A, B, C);
                    Console.WriteLine(" ");
                    Console.WriteLine("El perimetro del triangulo es: " + T.CalcularArea());
                    Console.WriteLine(" ");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    MenuTriangulo();
                    break;
                case '3':
                    MenuInicial();
                    break;
                case '0':
                    break;
            }

        }

        private static void MenuCirculo()
        {
            //Declaro las variables a utilizar en este metodo.
            double xA;
            double yA;
            Punto A;
            double radio;
            Circulo C;

            Console.Clear();
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1 - Area de un Circulo.");
            Console.WriteLine("2 - Perimetro de un Circulo.");
            Console.WriteLine("3 - Volver al menu principal.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");

            char opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    Console.WriteLine("--- Area de un Circulo ---");
                    Console.WriteLine("");

                    //Carga de datos del circulo.
                    Console.WriteLine("Ingrese los datos del circulo.");
                    Console.WriteLine("Ingrese las coordenadas del centro: ");
                    Console.Write("x: ");
                    xA = double.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    yA = double.Parse(Console.ReadLine());
                    A = new Punto(xA, yA);
                    Console.Write("Ingrese el radio del circulo: ");
                    radio = double.Parse(Console.ReadLine());
                    C = new Circulo(A, radio);
                    //Resultado del area de un circulo.
                    Console.WriteLine("El circulo de centro en ( " + A.GetX() + " , " + A.GetY() +  " ) y radio " + radio + " tiene un area de: " + C.CalcularAreaCirculo());
                    Console.Write("Presione una tecla para continuar.");
                    Console.ReadKey();
                    MenuCirculo();
                    break;
                case '2':
                    Console.WriteLine("--- Perimetro de un Circulo ---");
                    Console.WriteLine("");

                    //Carga de datos del circulo.
                    Console.WriteLine("Ingrese los datos del circulo.");
                    Console.WriteLine("Ingrese las coordenadas del centro: ");
                    Console.Write("x: ");
                    xA = double.Parse(Console.ReadLine());
                    Console.Write("y: ");
                    yA = double.Parse(Console.ReadLine());
                    A = new Punto(xA, yA);
                    Console.Write("Ingrese el radio del circulo: ");
                    radio = double.Parse(Console.ReadLine());
                    C = new Circulo(A, radio);
                    Console.WriteLine("El circulo de centro en ( " + A.GetX() + " , " + A.GetY() + " ) y radio " + radio + " tiene un perimetro de: " + C.CalcularPerimetroCirculo());
                    Console.Write("Presione una tecla para continuar.");
                    Console.ReadKey();
                    MenuCirculo();
                    break;
                case '3':
                    MenuInicial();
                    break;
                case '0':
                    break;
            }

        }
        public static void MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("Bienvenido! ¿Con que figura desea trabajar?");
            Console.WriteLine("1 - Punto.");
            Console.WriteLine("2 - Triangulo.");
            Console.WriteLine("3 - Circulo.");
            Console.Write("Ingrese la opcion deseada: ");
            char opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion)
            {
                case '1':
                    MenuPunto();
                    break;
                case '2':
                    MenuTriangulo();
                    break;
                case '3':
                    MenuCirculo();
                    break;
            }
        }
        static void Main()
        {
            MenuInicial();
        }
    }
}
