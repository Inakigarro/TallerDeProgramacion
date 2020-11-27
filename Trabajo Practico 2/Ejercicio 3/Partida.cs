using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    public enum Dificultad { Facil = 15, Normal = 10, Dificil = 5 };
    public enum Resultado { EnCurso = 0, Victoria = 1, Derrota = 2};
    public class Partida
    {
        private string nombreUsuario;
        private int numeroPartida;
        private DateTime fechaYHoraInicio;
        private DateTime fechaYHoraFin;
        private int vidas;
        private string dificultad;
        private string palabraElegida;
        private List<char> letrasIngresadas;
        private char[] palabraFormada;
        private string resultado;
        private ContenedorPalabras rPalabras = new ContenedorPalabras();
        public Partida(int pDificultad, string pNombre)
        {
            nombreUsuario = pNombre;
            switch (pDificultad)
            {
                case 1:
                    dificultad = Convert.ToString(Dificultad.Facil);
                    vidas = (int)Dificultad.Facil;
                    break;
                case 2:
                    dificultad = Convert.ToString(Dificultad.Normal);
                    vidas = (int)Dificultad.Normal;
                    break;
                case 3:
                    dificultad = Convert.ToString(Dificultad.Dificil);
                    vidas = (int)Dificultad.Dificil;
                    break;
            }
            palabraElegida = rPalabras.ElegirPalabra();
            palabraFormada = new char[palabraElegida.Length];
            letrasIngresadas = new List<char>();
            fechaYHoraInicio = DateTime.Now;
            resultado = Convert.ToString(Resultado.EnCurso);
        }
        public string GetNombre { get { return nombreUsuario; } }
        public int NumeroPartida 
        {
            set { numeroPartida = value; }
            get { return numeroPartida; }
        }
        public int GetVidas { get { return vidas; } }
        public string GetDificultad { get { return dificultad; } }
        public string GetPalabraElegida { get { return palabraElegida; } }
        public char[] GetPalabraFormada { get { return palabraFormada; } }
        public List<char> GetLetrasIngresadas { get { return letrasIngresadas; } }
        public DateTime GetFechaInicio { get { return fechaYHoraInicio; } }
        public DateTime GetFechaFin 
        { 
            get { return fechaYHoraFin; } 
            set { fechaYHoraFin = value; }
        }
        public TimeSpan GetDuracion { get { return this.GetFechaFin - this.GetFechaInicio; } }
        public string GetResultado { get { return resultado; } }

        public void InsertarLetra(char pLetra)
        {
            if (palabraElegida.Contains(pLetra))
            {
                if (palabraFormada.Contains(pLetra))
                {
                    vidas--;
                }
                else
                {
                    for (int i = 0; i < palabraElegida.Length; i++)
                    {
                        if (palabraElegida[i] == pLetra)
                        {
                            palabraFormada[i] = pLetra;
                        }
                    }
                } 
            }
            else
            {
                vidas--;
            }
            letrasIngresadas.Add(pLetra);
        }
        public void SetVictoria()
        {
            resultado = Convert.ToString(Resultado.Victoria);
        }
        public void SetDerrota()
        {
            resultado = Convert.ToString(Resultado.Derrota);
        }
    }
}
