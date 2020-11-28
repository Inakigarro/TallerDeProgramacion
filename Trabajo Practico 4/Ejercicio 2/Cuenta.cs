using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    public class Cuenta
    {
        //Atributos de la clase.
        private Moneda aMoneda;
        private double aSaldo;

        //Constructores de la clase.
        public Cuenta(string pCodigoISOMoneda, string pNombreMoneda, string pSimboloMoneda)
        {
            aMoneda = new Moneda(pCodigoISOMoneda, pNombreMoneda, pSimboloMoneda);
            aSaldo = 0;
        }
        public Cuenta(string pCodigoISOMoneda, string pNombreMoneda, string pSimboloMoneda, double pSaldo)
        {
            aMoneda = new Moneda(pCodigoISOMoneda, pNombreMoneda, pSimboloMoneda);
            aSaldo = pSaldo;
        }

        //Getters de la clase.
        public double Saldo { get { return aSaldo; } }
        public Moneda Moneda { get { return aMoneda; } }

        //Metodos de la clase.
        public void AcreditarSaldo(double pSaldo) 
        {
            if(pSaldo <= 0)
            {
                throw new SaldoIncorrectoException("El saldo ingresado no es correcto.");
            }
            else
            {
                aSaldo += pSaldo;
            }
        }
        public void DebitarSaldo(double pSaldo)
        {
            if (pSaldo > aSaldo)
            {
                throw new SaldoIncorrectoException("Saldo insuficiente para realizar esta operación");
            }
            else
            {
                aSaldo -= pSaldo;
            }
        }   
    }
}
