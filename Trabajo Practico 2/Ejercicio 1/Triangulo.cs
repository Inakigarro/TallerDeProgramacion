using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class Triangulo
    {
        //Los puntos que definen el triangulo.
        private Punto punto1;
        private Punto punto2;
        private Punto punto3;
        private double baseTriangulo = 0;
        private double altura = 0;

        //Constructor del triangulo.
        public Triangulo(Punto p1, Punto p2, Punto p3)
        {
            Punto puntoBase = new Punto(p3.GetX(), p1.GetY());
            punto1 = p1;
            punto2 = p2;
            punto3 = p3;
            baseTriangulo = punto1.CalcularDistanciaDesde(punto2);
            altura = punto3.CalcularDistanciaDesde(puntoBase);

        }

        //Devuelve el punto 1.
        public Punto GetP1()
        {
            return punto1;
        }

        //Devuelve el punto 2.
        public Punto GetP2()
        {
            return punto2;
        }

        //Devuelve el punto 3.
        public Punto GetP3()
        {
            return punto3;
        }

        //Calculo el area de un triangulo.
        public double CalcularArea()
        {
            double area = 0;
            area = (baseTriangulo * altura) / 2;
            return area;
        }

        //Calculo el perimetro de un triangulo.
        public double CalcularPerimetro()
        {
            double lado1 = 0;
            double lado2 = 0;
            double lado3 = 0;
            double perimetro = 0;
            lado1 = punto1.CalcularDistanciaDesde(punto2);
            lado2 = punto2.CalcularDistanciaDesde(punto3);
            lado3 = punto3.CalcularDistanciaDesde(punto1);
            perimetro = lado1 + lado2 + lado3;
            return perimetro;
        }
    }
}
