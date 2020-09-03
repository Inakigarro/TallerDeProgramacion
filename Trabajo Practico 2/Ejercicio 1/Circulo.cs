using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public struct Circulo
    {
        private Punto iCentro;
        private double iRadio;

        public Circulo(Punto pCentro, double pRadio)
        {
            iCentro = pCentro;
            iRadio = pRadio;
        }
        public Circulo(double pX, double pY, double pRadio)
        {
            Punto vPunto = new Punto(pX, pY);
            iCentro = vPunto;
            iRadio = pRadio;
        }

        public Punto Centro { get { return iCentro; } }
        public double Radio { get { return iRadio; } }
        public double Area()
        {
            double vArea = Math.Pow(Math.PI * iRadio, 2);
            return vArea;
        }
        public double Perimetro()
        {
            double vPerimetro = 2 * Math.PI * iRadio;
            return vPerimetro;
        }
    }
}
