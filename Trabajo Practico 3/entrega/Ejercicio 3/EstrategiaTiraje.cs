using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    public class EstrategiaTiraje : Estrategia
    {
        public override string GetIdEstrategia()
        {
            return "Tiraje";
        }
        public override Paciente SeleccionarTurno(List<Paciente> pListaTurnos)
        {
            var nivelUrgencia = 1;
            while(nivelUrgencia < 5)
            {
                var listaPacientes = pListaTurnos.FindAll(p => p.GetNivelUrgencia.Equals(nivelUrgencia));
                if(listaPacientes.Count != 0)
                {
                    return listaPacientes.OrderBy(p => p.GetHorarioTurno).First();
                }
                nivelUrgencia++;
            }
            return pListaTurnos.First();
        }
    }
}
