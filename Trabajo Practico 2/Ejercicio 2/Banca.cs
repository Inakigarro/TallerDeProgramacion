using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Banca
    {
        //Atributos de la Clase.
        private Cuenta cuentaEnPesos;
        private Cuenta cuentaEnDolares;
        private string nombreApellidoTitular;
        private string dniTitular;
        
        //Constructor de la clase.
        public Banca(string pNombreApellidoTitular, string pDniTitular)
        {
            cuentaEnPesos = new Cuenta("ARS", "Peso Argentino", "$");
            cuentaEnDolares = new Cuenta("USD", "Dolar Estadounidense", "U$D");
            nombreApellidoTitular = pNombreApellidoTitular;
            dniTitular = pDniTitular;
        }

        //Getters de la clase.
        public string GetTitular() { return nombreApellidoTitular; }
        public string GetDniTitular() { return dniTitular; }
        public Cuenta GetCuentaEnPesos() { return cuentaEnPesos; }
        public Cuenta GetCuentaEnDolares() { return cuentaEnDolares; }
    }
}
