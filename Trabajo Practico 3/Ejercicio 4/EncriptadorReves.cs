using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    public class EncriptadorReves : Encriptador
    {
        public EncriptadorReves() : base("Reves")
        {

        }
        public override string Desencriptar(string pCadena)
        {
            char[] cadenaSalida = new char[pCadena.Length];
            for (int i = 0; i < pCadena.Length; i++)
            {
                cadenaSalida[i] = pCadena.ElementAt((pCadena.Length -1) - i);
            }
            return new string(cadenaSalida);
        }

        public override string Encriptar(string pCadena)
        {
            char[] cadenaSalida = new char[pCadena.Length];
            for (int i = 0; i < pCadena.Length; i++)
            {
                cadenaSalida[i] = pCadena.ElementAt((pCadena.Length - 1) - i);
            }
            return new string(cadenaSalida);
        }
    }
}
