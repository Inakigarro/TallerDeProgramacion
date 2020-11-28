using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4
{
    public class EncriptadorNulo : Encriptador
    {
        public EncriptadorNulo() : base("Nulo")
        {

        }

        public override string Desencriptar(string pCadena)
        {
            return pCadena;
        }

        public override string Encriptar(string pCadena)
        {
            return pCadena;
        }
    }
}
