using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace Ejercicio_3
{
    public class InformacionPartida
    {
        private string nombreUsuario;
        private int vidas;
        private string dificultad;
        private string palabraElegida;
        private List<char> letrasIngresadas;
        private char[] palabraFormada;
        private string resultado;
        private TimeSpan duracionPartida;
        public InformacionPartida(Partida pPartida)
        {
            nombreUsuario = pPartida.GetNombre;
            vidas = pPartida.GetVidas;
            dificultad = pPartida.GetDificultad;
            palabraElegida = pPartida.GetPalabraElegida;
            letrasIngresadas = pPartida.GetLetrasIngresadas;
            palabraFormada = pPartida.GetPalabraFormada;
            resultado = pPartida.GetResultado;
            duracionPartida = pPartida.GetDuracion;
        }
        public string NombreUsuario { get { return nombreUsuario; } }
        public int Vidas { get { return vidas; } }
        public string Dificultad { get { return dificultad; } }
        public string PalabraElegida { get { return palabraElegida; } }
        public List<char> LetrasIngresadas { get { return letrasIngresadas; } }
        public char[] PalabraFormada { get { return palabraFormada; } }
        public string Resultado { get { return resultado; } }
        public TimeSpan GetDuracion { get { return duracionPartida; } }
    }
}
