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
            aHospital.CargarSala(TipoSala.Consulta);
            aHospital.CargarSala(TipoSala.Urgencias);
        }
        public void CargarPaciente(Sala pSala, Paciente pPaciente)
        {
            aHospital.CargarPaciente(pSala, pPaciente);
        }
        public void CambiarEstrategia(Sala pSala, Estrategia pEstrategia)
        {
            aHospital.CambiarEstrategiaSala(pSala, pEstrategia);
        }
        public void CargaAleatoriaTurnos(List<Paciente> pListaPacientes)
        {
            aHospital.CargaAleatoriaTurnos(pListaPacientes);
        }
        public Paciente SeleccionarPacienteConsulta()
        {
            aHospital.
        }
    }
}
