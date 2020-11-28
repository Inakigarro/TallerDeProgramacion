using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class EvaluadorAntiguedadLaboral : IEvaluador
    {
        //Atributos de la clase.
        private int aAntiguedadMinima;

        //Constructor de la clase.
        public EvaluadorAntiguedadLaboral(int pAntiguedadMinima)
        {
            aAntiguedadMinima = pAntiguedadMinima;
        }

        //Metodos de la clase.
        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            //Inicializo el valor a devolver y calculo la antiguedad del cliente en su empleo.
            bool resultado = false;
            var fechaIngresoCliente = pSolicitudPrestamo.Cliente.Empleo.FechaIngreso;
            int cantidadMeses = DateTime.Today.Month - fechaIngresoCliente.Month;

            //Verifico que la antiguedad del cliente sea superior a la antiguedad minima. De serlo, devuelve true.
            if(cantidadMeses > aAntiguedadMinima)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
