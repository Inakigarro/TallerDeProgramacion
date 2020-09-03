using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Ejercicio_1
{
    public struct Punto
    {
        private double iX;
        private double iY;
        public Punto(double pX, double pY)
        {
            this.iX = pX;
            this.iY = pY;
        }
        public double X 
        {
            set { this.iX = value; }
            get { return this.iX; }
        }
        public double Y
        {
            set { this.iY = value; }
            get { return this.iY; }
        }
        public double Distancia(Punto p)
        {
            double distancia = Math.Sqrt(Math.Pow((p.X - this.X), 2) + Math.Pow((p.Y - this.Y), 2));
            return distancia;
        }
    }
}
