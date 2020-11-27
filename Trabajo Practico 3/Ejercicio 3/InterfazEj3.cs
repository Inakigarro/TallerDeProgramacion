using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ejercicio_3
{
    class InterfazEj3
    {
        FachadaEj3 fachada = new FachadaEj3();
        
        public void MenuPrincipal()
        {
            Console.Clear();
            fachada.CargarSalas();
            Console.WriteLine("--- BIENVENIDO AL HOSPITAL ---");
            Console.WriteLine("");
            Console.WriteLine("1 - Administracion de Pacientes.");
            Console.WriteLine("2 - Administracion de la sala de consultas.");
            Console.WriteLine("3 - Administracion de la sala de urgencias.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            Console.Write("Ingrese una opcion para continuar: ");
            var opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    MenuPacientes();
                    break;
                case 2:
                    MenuSalaConsultas();
                    break;
                case 3:
                    MenuSalaUrgencias();
                    break;
                default:
                    break;
            }
        }
        public void MenuPacientes()
        {
            Console.Clear();
            Console.WriteLine(" --- ADMINISTRACIÓN DE PACIENTES --- ");
            Console.WriteLine("");
            Console.WriteLine("Esta opcion generará pacientes de forma secuencial y los asignara aleatoriamente entre las salas de urgencia y consulta.");
            Console.WriteLine("Los pacientes tendran nombres de la forma 'nombre 1', 'nombre 2' al igual que sus dnis.");
            Console.WriteLine("1 - Cargar pacientes generados de forma aleatoria.");
            Console.WriteLine("");
            Console.WriteLine("0 - Volver al Menu principal.");
            Console.Write("Ingrese una opcion para continuar: ");
            var opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    fachada.CargaAleatoriaTurnos();
                    Console.WriteLine("Los pacientes han sido generados correctamente y han sido asignados");
                    Console.WriteLine("Y han sido asignados a las salas del hospital de forma aleatoria.");
                    Console.Write("Presione cualquier tecla para continuar: ");
                    Console.ReadKey();
                    MenuPrincipal();
                    break;
                default:
                    MenuPrincipal();
                    break;
            }
        }
        public void MenuSalaConsultas()
        {
            Console.Clear();
            Paciente paciente;
            var sala = fachada.BuscarSala(TipoSala.Consulta);
            Console.WriteLine(" --- SALA DE CONSULTAS --- ");
            Console.WriteLine(" 1 - Cargar paciente nuevo.");
            Console.WriteLine(" 2 - Atender nuevo paciente.");
            Console.WriteLine(" 3 - Cambiar criterio de seleccion de pacientes.");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Volver al menu principal.");
            Console.Write("Ingrese una opcion para continuar: ");
            var opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    string opcionBucle;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese los datos del paciente.");
                        Console.Write("Nombre completo: ");
                        var vNombre = Console.ReadLine();
                        Console.Write("DNI: ");
                        var vDni = Console.ReadLine();
                        Console.Write("Horario del turno (DD-MM-AAAA HH:mm): ");
                        var vHorario = Console.ReadLine();
                        Console.Write("Nivel de Urgencia (1 Atencion inmediata - 5 no urgente: ");
                        var vUrgencia = int.Parse(Console.ReadLine());
                        paciente = new Paciente(vNombre, vDni, DateTime.Parse(vHorario), vUrgencia);
                        fachada.CargarPaciente(sala, paciente);
                        Console.WriteLine("Desea cargar un nuevo paciente? 'Si' Para continuar, 'No' para volver al menu anterior");
                        opcionBucle = Console.ReadLine();
                    } while (opcionBucle.Equals("si"));
                    MenuSalaConsultas();
                    break;
                case 2:
                    Console.Clear();
                    paciente = fachada.SeleccionarPacienteConsulta();
                    Console.WriteLine("El paciente " + paciente.GetNombrePaciente + " con turno " + paciente.GetHorarioTurno);
                    Console.WriteLine("fue atendido con nivel de urgencia " + paciente.GetNivelUrgencia);
                    Console.WriteLine("");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    MenuSalaConsultas();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("La sala actual tiene la estrategia de seleccion: " + sala.GetEstrategia.GetIdEstrategia());
                    Console.Write("Para cambiar de estrategia, precione cualquier tecla.");
                    Console.ReadKey();
                    fachada.CambiarEstrategia(sala);
                    Console.WriteLine("La estrategia de seleccion de pacientes fue cambiada exitosamente a " + sala.GetEstrategia.GetIdEstrategia());
                    Console.ReadKey();
                    MenuSalaConsultas();
                    break;
                default:
                    MenuPrincipal();
                    break;
            }
        }
        public void MenuSalaUrgencias()
        {
            Console.Clear();
            Paciente paciente;
            var sala = fachada.BuscarSala(TipoSala.Urgencias);
            Console.WriteLine(" --- SALA DE URGENCIA --- ");
            Console.WriteLine(" 1 - Cargar paciente nuevo.");
            Console.WriteLine(" 2 - Atender nuevo paciente.");
            Console.WriteLine(" 3 - Cambiar criterio de seleccion de pacientes.");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Volver al menu principal.");
            Console.Write("Ingrese una opcion para continuar: ");
            var opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    string opcionBucle;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Ingrese los datos del paciente.");
                        Console.Write("Nombre completo: ");
                        var vNombre = Console.ReadLine();
                        Console.Write("DNI: ");
                        var vDni = Console.ReadLine();
                        Console.Write("Horario del turno (DD-MM-AAAA HH:mm): ");
                        var vHorario = Console.ReadLine();
                        Console.Write("Nivel de Urgencia (1 Atencion inmediata - 5 no urgente: ");
                        var vUrgencia = int.Parse(Console.ReadLine());
                        paciente = new Paciente(vNombre, vDni, DateTime.Parse(vHorario), vUrgencia);
                        fachada.CargarPaciente(sala, paciente);
                        Console.WriteLine("Desea cargar un nuevo paciente? 'Si' Para continuar, 'No' para volver al menu anterior");
                        opcionBucle = Console.ReadLine();
                    } while (opcionBucle.Equals("si"));
                    MenuSalaUrgencias();
                    break;
                case 2:
                    Console.Clear();
                    paciente = fachada.SeleccionarPacienteUrgencia();
                    Console.WriteLine("El paciente " + paciente.GetNombrePaciente + " con turno " + paciente.GetHorarioTurno);
                    Console.WriteLine("fue atendido con nivel de urgencia " + paciente.GetNivelUrgencia);
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                    MenuSalaUrgencias();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("La sala actual tiene la estrategia de seleccion: " + sala.GetEstrategia.GetIdEstrategia());
                    Console.Write("Para cambiar de estrategia, precione cualquier tecla.");
                    Console.ReadKey();
                    fachada.CambiarEstrategia(sala);
                    Console.WriteLine("La estrategia de seleccion de pacientes fue cambiada exitosamente a " + sala.GetEstrategia.GetIdEstrategia());
                    Console.ReadKey();
                    MenuSalaUrgencias();
                    break;
                default:
                    MenuPrincipal();
                    break;
            }
        }
    }
}
