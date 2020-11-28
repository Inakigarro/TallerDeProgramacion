using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class EvaluadorCantidadCuotas : IEvaluador
    {
        //Atributos de la clase.
        private int aCantidadMaximaCuotas;

        //Constructor de la clase.
        public EvaluadorCantidadCuotas(int pCantidadCuotas)
        {
            aCantidadMaximaCuotas = pCantidadCuotas;
        }

        //Metodos de la clase.
        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            bool resultado = false;
            if(pSolicitudPrestamo.CantidadCuotas < aCantidadMaximaCuotas)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
