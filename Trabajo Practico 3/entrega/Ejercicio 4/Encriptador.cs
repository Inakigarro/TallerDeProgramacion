using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4
{
    public abstract class Encriptador : IEncriptador  
    {
        //Atributos de la clase.
        private string aNombre;

        //Constructores de la clase.
        public Encriptador(string pNombre)
        {
            aNombre = pNombre;
        }

        //Getters de la clase.
        public virtual string GetNombre() { return aNombre; } 

        //Metodos de la clase.
        public abstract string Encriptar(string pCadena);
        public abstract string Desencriptar(string pCadena);
    }
}
