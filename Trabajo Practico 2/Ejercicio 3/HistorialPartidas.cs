using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    class HistorialPartidas
    {
        private Partida[] hPartidas;

        public HistorialPartidas()
        {
            hPartidas = new Partida[10];
        }
        public Partida[] GetPartidas { get { return hPartidas; } }

        public void GuardarPartida(Partida pPartida)
        {
            for ( int i = 0; i < 10; i++)
            {
                if ( hPartidas[i] == null )
                {
                    hPartidas[i] = pPartida;
                    break;
                }
            }
        }

    }
}
