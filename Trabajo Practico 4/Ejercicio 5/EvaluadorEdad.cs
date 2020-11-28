using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class EvaluadorEdad : IEvaluador
    {
        //Atributos de la clase.
        private int aEdadMinima;
        private int aEdadMaxima;

        //Constructor de la clase.
        public EvaluadorEdad(int pEdadMinima, int pEdadMaxima)
        {
            aEdadMinima = pEdadMinima;
            aEdadMaxima = pEdadMaxima;
        }

        //Metodos de la clase.
        public bool EsValida (SolicitudPrestamo pSolicitudPrestamo)
        {
            //Inicializo el resultado y calculo la edad del cliente.
            bool resultado = false;
            int edadCliente = (DateTime.Today.Year - pSolicitudPrestamo.Cliente.FechaNacimiento.Year);

            //Verifico si la edad se encuentra dentro del rango determinado. De estarlo, devuelve true.
            if(edadCliente > aEdadMinima && edadCliente < aEdadMaxima)
            {
                resultado = true;
            }
            return resultado;
        }
    }
}
