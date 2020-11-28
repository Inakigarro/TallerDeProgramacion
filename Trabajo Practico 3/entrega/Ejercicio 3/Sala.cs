using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    public class Sala
    {
        //Atributos de la clase.
        private TipoSala aTipoSala;
        private int aIdSala;
        private List<Paciente>  aListaTurnos = new List<Paciente>();
        private Estrategia aAtencionCliente;
        //Constructores de la clase.
        public Sala(TipoSala pTipoSala, int pIdSala,  Estrategia pEstrategia)
        {
            aTipoSala = pTipoSala;
            aIdSala = pIdSala;
            aAtencionCliente = pEstrategia;
        }
        //Getters y Setters de la clase.
        public TipoSala GetTipoSala { get { return aTipoSala; } }
        public int GetIdSala { get { return aIdSala; } }
        public List<Paciente> GetListaTurnos { get { return aListaTurnos; } }
        public Estrategia GetEstrategia { get { return aAtencionCliente; } }
        //Metodos de la clase.
        public void AgregarTurno(Paciente pPaciente)
        {
            GetListaTurnos.Add(pPaciente);
            OrdenarTurnos();
        }
        public void OrdenarTurnos()
        {
            GetListaTurnos.OrderBy(p => p.GetNivelUrgencia);
        }
        public Paciente SeleccionarPaciente()
        {
            return aAtencionCliente.SeleccionarTurno(aListaTurnos);
        }
        public void CambiarEstrategia(Estrategia pEstrategia) { aAtencionCliente = pEstrategia; }
    }
}
