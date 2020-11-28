using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class EvaluadorMonto : IEvaluador
    {
        //Atributos de la clase.
        private double aMontoMaximo;

        //Constructor de la clase.
        public EvaluadorMonto(double pMontoMaximo)
        {
            aMontoMaximo = pMontoMaximo;
        }

        //Metodos de la clase.
        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            bool resultado = false;
            if(pSolicitudPrestamo.Monto < aMontoMaximo)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
