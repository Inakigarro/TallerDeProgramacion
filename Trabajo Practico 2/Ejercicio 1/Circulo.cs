using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class Circulo
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
        public double CalcularAreaCirculo() {  return Math.Pow(Math.PI * iRadio, 2); }
        public double CalcularPerimetroCirculo() { return 2 * Math.PI * iRadio; }
    }
}
