using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Ejercicio_3
{
    public enum TipoSala { Consulta = 0, Urgencias = 1 }
    
    public class Hospital
    {
        //Atributos de la clase.
        private List<Sala> salas = new List<Sala>();
        private Estrategia fifo = new EstrategiaFIFO();
        private Estrategia tiraje = new EstrategiaTiraje();
        //Constructores de la clase.
        public Hospital()
        {
        }
        //Getters y Setters de la clase.
        public List<Sala> GetListaSalas { get { return salas; } }
        //Metodos de la clase.
        public void CargarSala(TipoSala pTipoSala, int pIdSala)
        {
            
            if(pTipoSala == TipoSala.Consulta)
            {
                salas.Add(new Sala(pTipoSala, pIdSala, fifo));
            }
            else
            {
                salas.Add(new Sala(pTipoSala, pIdSala, tiraje));
            }
        }
        public Sala BuscarSala(TipoSala pTipoSala)
        {
            return salas.Find(s => s.GetTipoSala.Equals(pTipoSala));
        }
        public void CambiarEstrategiaSala(Sala pSala) 
        {
            if(pSala.GetEstrategia.GetIdEstrategia().Equals("FIFO"))
            {
                pSala.CambiarEstrategia(new EstrategiaTiraje());
            }
            else
            {
                pSala.CambiarEstrategia(new EstrategiaFIFO());
            }
        }
        public void CargarPaciente(Sala pSala, Paciente pPaciente)
        {
            pSala.AgregarTurno(pPaciente);
        }
        public void CargarPaciente(Sala pSala, string pNombrePaciente, string pDniPaciente, DateTime pHorarioTurno, int pNivelUrgencia)
        {
            var paciente = new Paciente(pNombrePaciente, pDniPaciente, pHorarioTurno, pNivelUrgencia);
            pSala.AgregarTurno(paciente);
        }
        public void CargaAleatoriaTurnos(List<Paciente> pListaPacientes)
        {
            var sala1 = salas.ElementAt(0);
            var sala2 = salas.ElementAt(1);
            var random = new Random();

            while (sala1.GetListaTurnos.Count < 10 || sala2.GetListaTurnos.Count < 10)
            {
                while (pListaPacientes.Count != 0)
                {
                    var salaRandom = salas.ElementAt(random.Next(0, salas.Count));
                    var primero = pListaPacientes.First();
                    if (salaRandom.GetListaTurnos.Count < 10)
                    {
                        salaRandom.AgregarTurno(primero);
                        pListaPacientes.Remove(primero);
                    }
                }
            }
        }
        public Paciente AtenderPacienteConsulta()
        {
            var sala = salas.Find(s => s.GetTipoSala == TipoSala.Consulta);
            return sala.SeleccionarPaciente();
        }
        public Paciente AtenderPacienteUrgencia()
        {
            var sala = salas.Find(s => s.GetTipoSala == TipoSala.Urgencias);
            return sala.SeleccionarPaciente();
        }
        public Paciente AtenderPaciente(TipoSala pTipoSala)
        {
            var sala = salas.Find(s => s.GetTipoSala == pTipoSala);
            return sala.SeleccionarPaciente();
        }
    }
}
