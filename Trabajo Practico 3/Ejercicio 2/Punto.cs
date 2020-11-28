using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Punto
    {
        //Atributos de la clase.
        private double aX;
        private double aY;

        //Constructor.
        public Punto(double pX, double pY)
        {
            aX = pX;
            aY = pY;
        }

        //Getters
        public double X { get { return aX; } }
        public double Y { get { return aY; } }

        //Metodos de la clase.
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            return Math.Sqrt(Math.Pow(pPunto.X - this.X, 2) + Math.Pow(pPunto.Y - this.Y, 2));
        }
    }
}
