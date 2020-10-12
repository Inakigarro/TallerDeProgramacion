using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    public class RepositorioPartidas
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
            partida.NumeroPartida = hPartidas.Count + 1;
            hPartidas.Add(partida);
        }
        public Partida BuscarPartida(int pNumeroPartida)
        {
            var partida = hPartidas.Find(p => p.NumeroPartida == pNumeroPartida);
            return partida;
        }
        public Partida CargarPartdaEnCurso()
        {
            return hPartidas.Find(p => p.GetResultado == Convert.ToString(Resultado.EnCurso));
        }
        public Partida CargarUltimaPartida()
        {
            return hPartidas.Last();
        }
        public void InsertarLetra(char pLetra)
        {
            var partida = CargarPartdaEnCurso();
            partida.InsertarLetra(pLetra);
        }
        public void SetVictoria()
        {
            var partida = CargarPartdaEnCurso();
            partida.SetVictoria();
        }
        public void SetDerrota()
        {
            var partida = CargarPartdaEnCurso();
            partida.SetDerrota();
        }
        public List<Partida> GetUltimasPartidas()
        {
            List<Partida> ultimasPartidas = new List<Partida>();
            if (hPartidas.Count < 5)
            {
                foreach (Partida p in hPartidas)
                {
                    ultimasPartidas.Add(p);
                }
            }
            else
            {
                for (int i = 5; i > 0; i--)
                {
                    var posicion = hPartidas.Count - i;
                    ultimasPartidas.Add(hPartidas[posicion]);
                }
            }
            return ultimasPartidas;
        }
    }
}
