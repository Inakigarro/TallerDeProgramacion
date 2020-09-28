using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class RepositorioPartidas
    {
        private List<Partida> hPartidas;

        public RepositorioPartidas()
        {
            hPartidas = new List<Partida>();
        }
        public List<Partida> GetPartidas { get { return hPartidas; } }

        public void CrearPartida(int pDificultad, string pNombre)
        {
            var partida = new Partida(pDificultad, pNombre);
            hPartidas.Add(partida);
        }
    }
}
