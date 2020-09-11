using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    class Partida
    {
        private DateTime fechaYHoraInicio;
        private DateTime fechaYHoraFin;
        private int vidas;
        private string dificultad;
        private string palabraElegida;
        private char[] letrasIngresadas;
        private char[] palabraFormada;
        private string resultado;
        private RepositorioPalabras rPalabras = new RepositorioPalabras();
        public Partida(string pDificultad)
        {
            dificultad = pDificultad;
            switch (pDificultad)
            {
                case "Facil":
                    vidas = 15;
                    break;
                case "Normal":
                    vidas = 10;
                    break;
                case "Dificil":
                    vidas = 5;
                    break;
            }
            palabraElegida = rPalabras.ElegirPalabra();
            palabraFormada = new char[palabraElegida.Length];
            letrasIngresadas = new char[30];
            fechaYHoraInicio = DateTime.Now;
        }
        public int Vidas { get { return vidas; } }
        public string Dificultad { get { return dificultad; } }
        public string PalabraElegida { get { return palabraElegida; } }
        public char[] PalabraFormada { get { return palabraFormada; } }
        public char[] LetrasIngresadas { get { return letrasIngresadas; } }
        public DateTime FechaInicio { get { return fechaYHoraInicio; } }
        public DateTime FechaFin 
        { 
            get { return fechaYHoraFin; } 
            set { fechaYHoraFin = value; }
        }
        public string Resultado
        {
            get { return resultado; }
            set { resultado = value; }
        }
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
            for(int i = 0; i < letrasIngresadas.Length; i++)
            {
                if(letrasIngresadas[i] == '\0')
                {
                    letrasIngresadas[i] = pLetra;
                    break;
                }
                
            }
        }

    }
}
