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

        //Constructores de la clase.
        public Cuenta(Moneda pMoneda)
        {
            iMoneda = pMoneda;
            iSaldo = 0;
        }
        public Cuenta(Moneda pMoneda, double pSaldo)
        {
            iMoneda = pMoneda;
            iSaldo = pSaldo;
        }

        //Getters de la clase.
        public Moneda GetMoneda() { return iMoneda; }
        public double GetSaldo() { return iSaldo; }

        //Metodos de la clase.
        public void AcreditarSaldo(double pSaldo)
        {
            iSaldo += pSaldo;
        }

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
