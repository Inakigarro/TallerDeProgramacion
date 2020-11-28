using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Circulo : FiguraGeometrica
    {
        //Atributos de la clase.
        Punto centro;
        double radio;

        //Constructores.
        public Circulo(Punto pCentro, double pRadio)
        {
            centro = pCentro;
            radio = pRadio;
        }
        public Circulo(double pX, double pY, double pRadio)
        {

        }
        //Getters.
        public Punto Centro { get { return centro; } }
        public double Radio { get { return radio; } }

        //Metodos de la clase.
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * radio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(radio, 2);
        }
    }
}
