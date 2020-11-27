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

        //Constructor de la clase.
        public Moneda(string pCodigoISO, string pNombre, string pSimbolo)
        {
            aCodigoISO = pCodigoISO;
            aNombre = pNombre;
            aSimbolo = pSimbolo;
        }

        //Getters de la clase.
        public string GetCodigoISO() { return aCodigoISO; }
        public string GetNombre() { return aNombre; }
        public string GetSimbolo() { return aSimbolo; }
    }
}
