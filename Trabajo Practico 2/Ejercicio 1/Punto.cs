using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Ejercicio_1
{
    public class Punto
    {
        private double iX;
        private double iY;
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }
        public double X { get { return this.iX; } }
        public double Y { get { return this.iY; } }
        public double CalcularDistanciaDesde(Punto pPuntoFinal)
        {
            return Math.Pow((pPuntoFinal.X - iX), 2) + Math.Pow((pPuntoFinal.Y - iY), 2);
        }
    }
}
