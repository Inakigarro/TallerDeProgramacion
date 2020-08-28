using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Moneda
    {
        //Atributos de la clase.
        private string iCodigoISO;
        private string iNombre;
        private string iSimbolo;

        //Constructor de la clase.
        public Moneda(string pCodigoISO, string pNombre, string pSimbolo)
        {
            iCodigoISO = pCodigoISO;
            iNombre = pNombre;
            iSimbolo = pSimbolo;
        }

        //Getters de la clase.
        public string GetCodigoISO() { return iCodigoISO; }
        public string GetNombre() { return iNombre; }
        public string GetSimbolo() { return iSimbolo; }


    }
}
