using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public abstract class Estrategia
    {
        public abstract string GetIdEstrategia();
        public abstract Paciente SeleccionarTurno(List<Paciente> pListaTurnos);                   
    }
}
