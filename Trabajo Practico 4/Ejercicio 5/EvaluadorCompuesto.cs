using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class EvaluadorCompuesto : IEvaluador
    {
        //Atributos de la clase.
        private List<IEvaluador> aEvaluadores = new List<IEvaluador>();

        //Constructor de la clase.
        public EvaluadorCompuesto()
        {

        }
        
        //Metodos de la clase.
        public void AgregarEvaluador(IEvaluador pEvaluador)
        {
            aEvaluadores.Add(pEvaluador);
        }
        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            
            foreach(IEvaluador evaluador in aEvaluadores)
            {
                bool resultado = evaluador.EsValida(pSolicitudPrestamo);
                if(resultado == false)
                {
                    return resultado;
                }
            }
            return true;
        }
    }
}
