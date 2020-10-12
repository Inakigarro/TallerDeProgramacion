using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public class Paciente
    {
        //Atributos de la clase.
        private string aNombrePaciente;
        private string aDniPaciente;
        private DateTime aHorarioTurno;
        private int aNivelUrgencia;
        //Constructores.
        public Paciente (string pNombrePaciente, string pDniPaciente, DateTime pHorarioTurno, int pNivelUrgencia)
        {
            aNombrePaciente = pNombrePaciente;
            aDniPaciente = pDniPaciente;
            aHorarioTurno = pHorarioTurno;
            aNivelUrgencia = pNivelUrgencia;
        }
        //Getters de la clase.
        public string GetNombrePaciente { get { return aNombrePaciente; } }
        public string GetDniPaciente { get { return aDniPaciente; } }
        public DateTime GetHorarioTurno { get { return aHorarioTurno; } }
        public int GetNivelUrgencia { get { return aNivelUrgencia; } }
        //Metodos de la clase.
    }
}
