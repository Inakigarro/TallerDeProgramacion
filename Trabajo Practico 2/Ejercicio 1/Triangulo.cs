using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Ejercicio_1
{
    public struct Triangulo 
    {
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.iPunto1 = pPunto1;
            this.iPunto2 = pPunto2;
            this.iPunto3 = pPunto3;
        }

        public double Area()
        {
            Punto puntoBase = new Punto(this.iPunto3.X, this.iPunto1.Y);
            double vBase = this.iPunto1.Distancia(this.iPunto2);
            double area = (vBase * (this.iPunto3.Distancia(puntoBase))) / 2;
            return area;

        }   
        public double Perimetro()
        {
            double perimetro = this.iPunto1.Distancia(this.iPunto2) + this.iPunto2.Distancia(iPunto3) + this.iPunto3.Distancia(this.iPunto1);
            return perimetro;
        }
    }
}
