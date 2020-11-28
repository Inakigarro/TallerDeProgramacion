using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class FachadaEj5
    {
        private GestorPrestamos aGestorPrestamos = new GestorPrestamos();

        //Metodos de la clase.
        public Empleo CrearEmpleo(double pSueldo, DateTime pFechaIngreso)
        {
            Empleo vEmpleo = new Empleo(pSueldo, pFechaIngreso);
            return vEmpleo;
        }
        public Cliente CrearCliente(string pNombre, string pApellido, DateTime pFechaNacimiento, Empleo pEmpleo, TipoCliente pTipoCliente)
        {
            Cliente vCliente = new Cliente(pNombre, pApellido, pEmpleo, pFechaNacimiento);
            vCliente.TipoCliente = pTipoCliente;
            return vCliente;
        }
        public SolicitudPrestamo CrearSolicitudPrestamo(Cliente pCliente, double pMonto, int pCantidadCuotas)
        {
            SolicitudPrestamo vSolicitudPrestamos = new SolicitudPrestamo(pCliente, pMonto, pCantidadCuotas);
            return vSolicitudPrestamos;
        }

        public bool ValidarSolicitudPrestamo(SolicitudPrestamo pSolicitudPrestamo)
        {
            return aGestorPrestamos.EsValida(pSolicitudPrestamo);
        }


    }
}
