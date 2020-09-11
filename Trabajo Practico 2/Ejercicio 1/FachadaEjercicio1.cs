using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class FachadaEjercicio1
    {
        public double CalcularDistanciaEntrePuntos(double pPunto1X, double pPunto1Y, double pPunto2X, double pPunto2Y)
        {
            var punto1 = new Punto(pPunto1X, pPunto1Y);
            var punto2 = new Punto(pPunto2X, pPunto2Y);
            return punto1.CalcularDistanciaDesde(punto2);
        }
        public double CalcularAreaDeUnTriangulo(double pPunto1X, double pPunto1Y, double pPunto2X, double pPunto2Y, double pPunto3X, double pPunto3Y)
        {
            Punto punto1 = new Punto(pPunto1X, pPunto1Y);
            Punto punto2 = new Punto(pPunto2X, pPunto2Y);
            Punto punto3 = new Punto(pPunto3X, pPunto3Y);
            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);
            return triangulo.CalcularAreaTriangulo();
        }
        public double CalcularAreaDeUnTriangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            Triangulo triangulo = new Triangulo(pPunto1, pPunto2, pPunto3);
            return triangulo.CalcularAreaTriangulo();
        }
        public double CalcularPerimetroDeUnTriangulo(double pPunto1X, double pPunto1Y, double pPunto2X, double pPunto2Y, double pPunto3X, double pPunto3Y)
        {
            Punto punto1 = new Punto(pPunto1X, pPunto1Y);
            Punto punto2 = new Punto(pPunto2X, pPunto2Y);
            Punto punto3 = new Punto(pPunto3X, pPunto3Y);
            Triangulo triangulo = new Triangulo(punto1, punto2, punto3);
            return triangulo.CalcularPerimetroTriangulo();
        }
        public double CalcularPerimetroDeUnTriangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            Triangulo triangulo = new Triangulo(pPunto1, pPunto2, pPunto3);
            return triangulo.CalcularPerimetroTriangulo();
        }
        public double CalcularAreaDeUnCirculo(double pCentroX, double pCentroY, double pRadio)
        {
            Punto centro = new Punto(pCentroX, pCentroY);
            Circulo circulo = new Circulo(centro, pRadio);
            return circulo.CalcularAreaCirculo();
        }
        public double CalcularAreaDeUnCirculo(Punto pCentro, double pRadio)
        {
            Circulo circulo = new Circulo(pCentro, pRadio);
            return circulo.CalcularAreaCirculo();
        }
        public double CalcularPerimetroCirculo(double pCentroX, double pCentroY, double pRadio)
        {
            Punto centro = new Punto(pCentroX, pCentroY);
            Circulo circulo = new Circulo(centro, pRadio);
            return circulo.CalcularPerimetroCirculo();
        }
        public double CalcularPerimetroCirculo(Punto pCentro, double pRadio)
        {
            Circulo circulo = new Circulo(pCentro, pRadio);
            return circulo.CalcularPerimetroCirculo();
        }
    }
}
