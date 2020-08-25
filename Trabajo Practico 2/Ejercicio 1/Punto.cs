using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Ejercicio_1
{
    class Punto
    {
        //Las coordeandas del punto x e y.
        private double iX;
        private double iY;

        //El constructor crea un nuevo punto con las coordenadas que se le pase como argumento.
        public Punto(double pX, double pY)
        {
            iX = pX;
            iY = pY;
        }

        //Devuelve la coordenada en x
        public double GetX()
        {
            return iX;
        }

        //Devuelve la coordenada en y
        public double GetY()
        {
            return iY;
        }

        //Calcula la distancia al punto pasado como parametro.
        public double CalcularDistanciaDesde(Punto p)
        {
            double distancia = 0;
            distancia = Math.Sqrt(Math.Pow((p.GetX() - iX), 2) + Math.Pow((p.GetY() - iY), 2));
            return distancia;
        }
    }
}
