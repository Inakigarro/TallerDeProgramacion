using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class Empleo
    {
        //Atributos de la clase.
        private double aSueldo;
        private DateTime aFechaIngreso;

        //Constructor de la clase.
        public Empleo(double pSueldo, DateTime pFechaIngreso)
        {
            aSueldo = pSueldo;
            aFechaIngreso = pFechaIngreso;
        }

        //Getters y Setters de la clase.
        public double Sueldo { get { return aSueldo; } }
        public DateTime FechaIngreso { get { return aFechaIngreso; } }
    }
}
