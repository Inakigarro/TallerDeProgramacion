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
        private Cliente titular;
        
        //Constructor de la clase.
        public Banca(Cliente pCliente)
        {
            Moneda pMonedaPeso = new Moneda("PESO", "Peso Argentino" , "ARG");
            Moneda pMonedaDolar = new Moneda("Dolar", "Dolar Estadounidense", "USD");
            cuentaEnPesos = new Cuenta(pMonedaPeso);
            cuentaEnDolares = new Cuenta(pMonedaDolar);
            titular = pCliente;
        }

        //Getters de la clase.
        public Cliente GetTitular()
        {
            Cliente iCliente = titular;
            return iCliente;
        }

        public string GetNumeroBanca()
        {
            string iNumeroBanca = titular.GetDni();
            return iNumeroBanca;
        }

        public Cuenta GetCuentaEnPesos() { return cuentaEnPesos; }
        public Cuenta GetCuentaEnDolares() { return cuentaEnDolares; }
    }
}
