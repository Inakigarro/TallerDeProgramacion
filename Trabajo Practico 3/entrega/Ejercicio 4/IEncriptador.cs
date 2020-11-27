using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4
{
    public interface IEncriptador
    {
        public string GetNombre();
        public string Encriptar(string pCadena);
        public string Desencriptar(string pCadena);
    }
}
