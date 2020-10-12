using System;
using System.Collections.Generic;

namespace Ejercicio_3
{
    class FachadaEjercicio3
    {
        RepositorioPartidas hPartidas = new RepositorioPartidas();
        public void CrearPartida(int pDificultad, string pNombreJugador)
        {
             hPartidas.CrearPartida(pDificultad, pNombreJugador);
        }
        public InformacionPartida CargarPartidaEnCurso()
        {
            var partida = hPartidas.CargarPartdaEnCurso();
            return new InformacionPartida(partida);
        }
        public InformacionPartida CargarUltimaPartida()
        {
            var partida = hPartidas.CargarUltimaPartida();
            return new InformacionPartida(partida);
        }
        public void IngresarLetra(char pLetra)
        {
            hPartidas.InsertarLetra(pLetra);
        }
        public InformacionPartida SetVictoria()
        {
            hPartidas.SetVictoria();
            var partida = hPartidas.CargarUltimaPartida();
            return new InformacionPartida(partida);
        }
        public InformacionPartida SetDerrota()
        {
            hPartidas.SetDerrota();
            var partida = hPartidas.CargarUltimaPartida();
            return new InformacionPartida(partida);
        }
        public List<InformacionPartida> CargarHistorialPartidas()
        {
            var historialPartidas = hPartidas.GetUltimasPartidas();
            var ultimasPartidas = new List<InformacionPartida>();
            foreach (Partida p in historialPartidas)
            {
                var infoPartida = new InformacionPartida(p);
                ultimasPartidas.Add(infoPartida);
            }
            return ultimasPartidas;
        }

    }
}
