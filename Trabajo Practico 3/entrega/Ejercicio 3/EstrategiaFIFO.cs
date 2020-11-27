using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    public class EstrategiaFIFO : Estrategia
    {
        public override string GetIdEstrategia()
        {
            return "FIFO";
        }
        public override Paciente SeleccionarTurno(List<Paciente> pListaTurnos)
        {
            //Devuelve el primer elemento de la lista.
            return pListaTurnos.First();

        }
    }
}
