using Ejercicio_3;
using System;
using Xunit;

namespace PruebasEj3
{
    public class UnitTest1
    {
        [Fact]
        public void PruebaEstrategiaTiraje()
        {
            //Inicializacion del obejto de prueba.
            var sala = new Sala(TipoSala.Urgencias, new EstrategiaTiraje());

            var paciente1 = new Paciente("Tuvieja", "1", DateTime.Now, 1);
            var paciente2 = new Paciente("Tuvieja2", "2", DateTime.Now, 1);
            var paciente3 = new Paciente("Tuvieja3", "3", DateTime.Now, 5);

            sala.AgregarTurno(paciente3);
            sala.AgregarTurno(paciente1);
            sala.AgregarTurno(paciente2);

            //Prueba del metodo de seleccion de pacientes.

            var pacienteElegido = sala.SeleccionarPaciente();

            //Verificacion del resultado.
            Assert.Equal(paciente1, pacienteElegido);
        }
        [Fact]
        public void PruebaEstrategiaFIFO()
        {
            //Inicializacion del obejto de prueba.
            var sala = new Sala(TipoSala.Urgencias, new EstrategiaFIFO());

            var paciente1 = new Paciente("Tuvieja", "1", DateTime.Now, 1);
            var paciente2 = new Paciente("Tuvieja2", "2", DateTime.Now, 1);
            var paciente3 = new Paciente("Tuvieja3", "3", DateTime.Now, 5);

            sala.AgregarTurno(paciente3);
            sala.AgregarTurno(paciente1);
            sala.AgregarTurno(paciente2);

            //Prueba del metodo de seleccion de pacientes.

            var pacienteElegido = sala.SeleccionarPaciente();

            //Verificacion del resultado.
            Assert.Equal(paciente3, pacienteElegido);
        }
        [Fact]
        public void PruebaCambioDeEstrategia()
        {
            //Inicializacion del obejto de prueba.
            var sala = new Sala(TipoSala.Urgencias, new EstrategiaTiraje());

            var paciente1 = new Paciente("Tuvieja", "1", DateTime.Now, 1);
            var paciente2 = new Paciente("Tuvieja2", "2", DateTime.Now, 1);
            var paciente3 = new Paciente("Tuvieja3", "3", DateTime.Now, 5);

            sala.AgregarTurno(paciente3);
            sala.AgregarTurno(paciente1);
            sala.AgregarTurno(paciente2);

            //Prueba del metodo de cambio de estrategia.

            var pacienteElegido1 = sala.SeleccionarPaciente();
            sala.CambiarEstrategia(new EstrategiaFIFO());
            var pacienteElegido2 = sala.SeleccionarPaciente();

            //Verificacion del resultado.
            Assert.False(pacienteElegido1 == pacienteElegido2, pacienteElegido1.GetNombrePaciente);
        }
    }
}
