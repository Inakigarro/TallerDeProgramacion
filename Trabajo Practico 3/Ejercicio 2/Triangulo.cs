using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Triangulo : FiguraGeometrica
    {
        //Atributos de la clase.
        private Punto punto1;
        private Punto punto2;
        private Punto punto3;

        //Constructores.
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            punto1 = pPunto1;
            punto2 = pPunto2;
            punto3 = pPunto3;
        }
        
        //Getters
        public Punto Punto1 { get { return punto1; } }
        public Punto Punto2 { get { return punto2; } }
        public Punto Punto3 { get { return punto3; } }

        //Metodos de la clase.
        public override double CalcularArea()
        {
            var ladoBase = punto1.CalcularDistanciaDesde(punto2);
            var puntoBase = new Punto(this.punto3.X, this.punto1.Y);
            return (ladoBase * this.punto3.CalcularDistanciaDesde(puntoBase)) / 2;
        }
        public override double CalcularPerimetro()
        {
            return this.punto1.CalcularDistanciaDesde(Punto2) + this.punto2.CalcularDistanciaDesde(Punto2) + this.punto3.CalcularDistanciaDesde(Punto1);
        }
    }
}
