using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class InterfazEj3
    {
        FachadaEjercicio3 fachada = new FachadaEjercicio3();
        public void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine(" --- Bienvenido al Ahorcado --- ");
            Console.WriteLine("");
            Console.WriteLine("1 - Crear nueva Partida.");
            Console.WriteLine("2 - Revisar historial de Partidas.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            Console.Write("Opcion: ");
            char opcion = Convert.ToChar(Console.ReadLine());
            if (Char.IsDigit(opcion))
            {
                switch (opcion)
                {
                    case '1':
                        MenuPartida();
                        break;
                    case '2':
                        MenuHistorial();
                        break;
                    case '0':
                        break;
                }
            }
        }
        public void MenuPartida()
        {
            Console.Clear();
            Console.WriteLine("Elija el nivel de dificultad con el que quiere jugar: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Facil.");
            Console.WriteLine("2 - Normal.");
            Console.WriteLine("3 - Dificil.");
            Console.WriteLine("");
            Console.Write("Ingrese una opcion para continuar: ");
            char opcion = Convert.ToChar(Console.ReadLine());
            if (Char.IsDigit(opcion))
            {
                switch (opcion)
                {
                    case '1':
                        Console.Clear();
                        fachada.CrearPartida("Facil");
                        fachada.JugarPartida();
                        MenuPrincipal();
                        break;
                    case '2':
                        Console.Clear();
                        fachada.CrearPartida("Normal");
                        fachada.JugarPartida();
                        MenuPrincipal();
                        break;
                    case '3':
                        Console.Clear();
                        fachada.CrearPartida("Dificil");
                        fachada.JugarPartida();
                        MenuPrincipal();
                        break;
                }
            }
        }
        public void MenuHistorial()
        {
            fachada.MostrarHitorialPartidas();
            Console.ReadKey();
            MenuPrincipal();
        }
    }
}
