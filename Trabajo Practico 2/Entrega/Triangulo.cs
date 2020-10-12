using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ejercicio_1
{
    public class Triangulo 
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            iPunto1 = pPunto1;
            iPunto2 = pPunto2;
            iPunto3 = pPunto3;
        }

        public Punto Punto1 { get{ return iPunto1; } }
        public Punto Punto2 { get { return iPunto2; } }
        public Punto Punto3 { get { return iPunto3; } }
        public double CalcularAreaTriangulo()
        {
            Punto puntoBase = new Punto(this.iPunto3.X, this.iPunto1.Y);
            double vBase = this.iPunto1.CalcularDistanciaDesde(this.iPunto2);
            double area = (vBase * (this.iPunto3.CalcularDistanciaDesde(puntoBase))) / 2;
            return area;

        }   
        public double CalcularPerimetroTriangulo()
        {
            double perimetro = this.iPunto1.CalcularDistanciaDesde(this.iPunto2) + this.iPunto2.CalcularDistanciaDesde(iPunto3) + this.iPunto3.CalcularDistanciaDesde(this.iPunto1);
            return perimetro;
        }
    }
}
