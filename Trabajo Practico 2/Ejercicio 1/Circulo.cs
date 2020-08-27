using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class Circulo
    {
        //Atributos de un circulo.
        private double radio;
        private Punto centro;

        //Constructor del circulo.
        public Circulo(Punto p, double r)
        {
            centro = p;
            radio = r;
        }

        //Devuelve el radio del circulo.
        public double GetRadio()
        {
            return radio;
        }

        //Devuelve el punto central del circulo.
        public Punto GetCentro()
        {
            return centro;
        }

        //Metodo que calcula el area del circulo.
        public double CalcularAreaCirculo()
        {
            double area = Math.PI * Math.Pow(radio, 2);
            return area;
        }
        

        //Metodo que calcula el perimetro de un circulo.
        public double CalcularPerimetroCirculo()
        {
            double perimetro = 2 * Math.PI * radio;
            return perimetro;
        }

    }
}
