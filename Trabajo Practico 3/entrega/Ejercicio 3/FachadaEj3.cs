using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    public class FachadaEj3
    {
        public Hospital aHospital = new Hospital();
        public List<Paciente> aListaPacientes = new List<Paciente>();
        public void CargarSalas()
        {
            aHospital.CargarSala(TipoSala.Consulta, 1);
            aHospital.CargarSala(TipoSala.Urgencias, 2);
        }
        public Sala BuscarSala(TipoSala pTipoSala)
        {
            return aHospital.BuscarSala(pTipoSala);
        }
        public void CargarPaciente(Sala pSala, Paciente pPaciente)
        {
            aHospital.CargarPaciente(pSala, pPaciente);
        }
        public void CargarPaciente(Sala pSala, string pNombrePaciente, string pDniPaciente, DateTime pHorarioTurno, int pNivelUrgencia)
        {
            aHospital.CargarPaciente(pSala, pNombrePaciente, pDniPaciente, pHorarioTurno, pNivelUrgencia);
        }
        public void CambiarEstrategia(Sala pSala)
        {
            aHospital.CambiarEstrategiaSala(pSala);
        }
        public void CargaAleatoriaTurnos()
        {
            for (int i = 0; i < 20; i++)
            {
                aListaPacientes.Add(new Paciente("nombre " + Convert.ToString(i), Convert.ToString(i), DateTime.Today, new Random().Next(1, 6)));
            }
            aHospital.CargaAleatoriaTurnos(aListaPacientes);
        }
        public Paciente SeleccionarPacienteConsulta()
        {
            var pacienteSeleccionado = aHospital.AtenderPacienteConsulta();
            return pacienteSeleccionado;
        }
        public Paciente SeleccionarPacienteUrgencia()
        {
            return aHospital.AtenderPacienteUrgencia();
        }
        public Paciente SeleccionarPaciente(TipoSala pTipoSala)
        {
            return aHospital.AtenderPaciente(pTipoSala);
        }
    }
}
