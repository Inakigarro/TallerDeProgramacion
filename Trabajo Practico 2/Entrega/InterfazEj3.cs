using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public class InterfazEj3
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
            Console.Write("Ingrese su nombre: ");
            var vNombre = Console.ReadLine();
            Console.WriteLine("Elija el nivel de dificultad con el que quiere jugar: ");
            Console.WriteLine("");
            Console.WriteLine("1 - Facil.");
            Console.WriteLine("2 - Normal.");
            Console.WriteLine("3 - Dificil.");
            Console.WriteLine("");
            Console.Write("Ingrese una opcion para continuar: ");
            int opcion = Convert.ToInt32(Console.ReadLine());
            fachada.CrearPartida(opcion, vNombre);
            MenuJugarPartida();            
        }
        public void MenuJugarPartida()
        {
            var infoPartida = fachada.CargarPartidaEnCurso();
            var palabraFormada = new string(infoPartida.PalabraFormada);
            while (!infoPartida.PalabraElegida.Equals(palabraFormada) && infoPartida.Vidas!= 0)
            {
                Console.Clear();
                Console.WriteLine(" --- Ahorcado: " + infoPartida.Dificultad + " --- ");
                Console.WriteLine("");
                Console.WriteLine("Vidas: " + infoPartida.Vidas);
                Console.WriteLine("Longitud de la palabra elegida: " + infoPartida.PalabraElegida.Length);
                MostrarPalabraFormada(infoPartida);
                Console.WriteLine();
                Console.WriteLine("Letras ingresadas: ");
                MostrarLetrasIngresadas(infoPartida);
                Console.WriteLine();
                Console.Write("Ingrese una letra: ");
                char vLetra = Convert.ToChar(Console.ReadLine());
                fachada.IngresarLetra(vLetra);
                infoPartida = fachada.CargarPartidaEnCurso();
                palabraFormada = new string(infoPartida.PalabraFormada);
            }
            if (infoPartida.PalabraElegida.Equals(palabraFormada))
            {
                var infoPartidaFinal = fachada.SetVictoria();
                Console.Clear();
                Console.WriteLine(" --- " + infoPartidaFinal.Resultado + " --- ");
                Console.WriteLine("");
                Console.WriteLine("Vidas restantes: " + infoPartidaFinal.Vidas);
                Console.Write("La palabra era: ");
                MostrarPalabraFormada(infoPartidaFinal);
                Console.WriteLine();
                Console.Write("Letras ingresadas : ");
                MostrarLetrasIngresadas(infoPartidaFinal);
                Console.WriteLine();
                Console.WriteLine("Duracion: " + infoPartidaFinal.GetDuracion);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Presione una tecla para continuar: ");
                Console.ReadKey();
                MenuPrincipal();
            }
            else
            {
                var infoPartidaFinal = fachada.SetDerrota();
                Console.Clear();
                Console.WriteLine(" --- " + infoPartidaFinal.Resultado + " --- ");
                Console.WriteLine("");
                Console.WriteLine("La palabra era : " + infoPartidaFinal.PalabraElegida);
                Console.WriteLine("Letras ingresadas: ");
                MostrarLetrasIngresadas(infoPartida);
                Console.WriteLine();
                Console.WriteLine("Duracion: " + infoPartidaFinal.GetDuracion);
                Console.WriteLine("-------------------------------------------------");
                Console.WriteLine("Presione una tecla para continuar: ");
                Console.ReadKey();
                MenuPrincipal();
            }

        }
        public void MenuHistorial()
        {
            Console.Clear();
            var historialPartidas = fachada.CargarHistorialPartidas();
            foreach(InformacionPartida p in historialPartidas)
            {
                Console.WriteLine("--------------------------------------------");
                Console.WriteLine("Jugador: " + p.NombreUsuario);
                Console.WriteLine("Dificultad: " + p.Dificultad);
                Console.WriteLine("Vidas: " + p.Vidas);
                Console.WriteLine("Palabra Elegida: " + p.PalabraElegida);
                Console.WriteLine("Palabra Formada: " + p.PalabraFormada);
                Console.WriteLine("Letras ingresadas: " + p.LetrasIngresadas);
                Console.WriteLine("Resultado: " + p.Resultado);
            }
            Console.WriteLine("Presione una tecla para continuar:");
            Console.ReadKey();
            MenuPrincipal();
        }
        public void MostrarPalabraFormada(InformacionPartida pInfoPartida)
        {
            foreach(char c in pInfoPartida.PalabraFormada)
            {
                if (c == '\0')
                {
                    Console.Write(" _ ");
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
        public void MostrarLetrasIngresadas(InformacionPartida pInfoPartida)
        {
            if(pInfoPartida.LetrasIngresadas.Count == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                foreach(char c in pInfoPartida.LetrasIngresadas)
                {
                    Console.Write(c + " ");
                }
            }
        }

    }
}
