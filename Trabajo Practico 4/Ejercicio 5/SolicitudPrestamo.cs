using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class SolicitudPrestamo
    {
        //Atributos de la clase.
        private Cliente aCliente;
        private double aMonto;
        private int aCantidadCuotas;

        //Constructor de la clase.
        public SolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            aCliente = pCliente;
            aMonto = pMonto;
            aCantidadCuotas = pCantidadCuotas;
        }

        //Getters de la clase.
        public Cliente Cliente { get { return aCliente; } }
        public double Monto { get { return aMonto; } }
        public int CantidadCuotas { get { return aCantidadCuotas; } }

    }
}
