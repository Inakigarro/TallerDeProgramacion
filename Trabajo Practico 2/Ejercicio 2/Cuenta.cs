using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Cuenta
    {
        //Atributos de la clase.
        private Moneda iMoneda;
        private double iSaldo;

        //Constructor sin saldo inicial.
        public Cuenta(string pCodigoISOMoneda, string pNombreMoneda, string pSimboloMoneda)
        {
            iMoneda = new Moneda(pCodigoISOMoneda, pNombreMoneda, pSimboloMoneda);
            iSaldo = 0;
        }

        //Constructor con saldo inicial.
        public Cuenta(string pCodigoISOMoneda, string pNombreMoneda, string pSimboloMoneda, double pSaldo)
        {
            iMoneda = new Moneda(pCodigoISOMoneda, pNombreMoneda, pSimboloMoneda);
            iSaldo = pSaldo;
        }

        //Getters de la clase.
        public double GetSaldo() { return iSaldo; }
        public string GetMoneda() { return iMoneda.GetCodigoISO(); }

        //Acredita el saldo de entrada añadiendo al valor actual el ingresado como parametro.
        public void AcreditarSaldo(double pSaldo) { iSaldo += pSaldo; }

        //Debita el saldo de entrada solo si hay saldo suficiente en la cuenta.
        public bool DebitarSaldo(double pSaldo)
        {
            if(iSaldo >= pSaldo)
            {
                iSaldo -= pSaldo;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
