using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    public class Moneda
    {
        //Atributos de la clase.
        private string aCodigoISO;
        private string aNombre;
        private string aSimbolo;

        //Constructores de la clase.
        public Moneda(string pCodigoISO, string pNombre, string pSimbolo)
        {
            aCodigoISO = pCodigoISO;
            aNombre = pNombre;
            aSimbolo = pSimbolo;
        }

        //Getters de la clase.
        public string CodigoISO { get { return aCodigoISO; } }
        public string Nombre { get { return aNombre; } }
        public string Simbolo { get { return aSimbolo; } }
    }
}
