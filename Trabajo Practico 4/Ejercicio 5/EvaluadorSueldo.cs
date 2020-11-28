using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class EvaluadorSueldo : IEvaluador
    {
        //Atributos de la clase.
        private double aSueldoMinimo;

        //Constructor de la clase.
        public EvaluadorSueldo(double pSueldoMinimo)
        {
            aSueldoMinimo = pSueldoMinimo;
        }

        //Metodos de la clase.
        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            bool resultado = false;
            if(pSolicitudPrestamo.Cliente.Empleo.Sueldo > aSueldoMinimo)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
