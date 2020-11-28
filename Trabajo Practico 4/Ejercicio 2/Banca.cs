using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    public class Banca
    {
        //Atributos de la clase.
        private Cuenta aCuentaEnPesos;
        private Cuenta aCuentaEnDolares;
        private string aNombreApellidoTitular;
        private string aDniTitular;

        //Constructor de la clase.
        public Banca(string pNombreApellidoTitular, string pDniTitular)
        {
            aCuentaEnPesos = new Cuenta("ARS", "Peso Argentino", "$");
            aCuentaEnDolares = new Cuenta("USD", "Dolar Estadounidense", "U$D");
            aNombreApellidoTitular = pNombreApellidoTitular;
            aDniTitular = pDniTitular;
        }

        //Getters de la clase.
        public string Titular { get { return aNombreApellidoTitular; } }
        public string Dni { get { return aDniTitular; } }
        public Cuenta CuentaEnPesos { get { return aCuentaEnPesos; } }
        public Cuenta CuentaEnDolares { get { return aCuentaEnDolares; } }
    }
}
