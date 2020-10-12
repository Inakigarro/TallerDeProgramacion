using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    public class FachadaEjercicio2
    {
        //Atributos de la fachada.
        RepositorioBanca rBanca;
        double valorDolar;

        //Constructor de la fachada.
        public FachadaEjercicio2()
        {
            rBanca = new RepositorioBanca();
            valorDolar = 74.38 * 1.3;
        }

        public double ValorDolar { get { return valorDolar; } }

        //Crea una banca y la guarda en el repositorio.
        public Banca CrearBanca(string pNombreApellidoTitular, string pDni)
        {
            var banca = new Banca(pNombreApellidoTitular, pDni);
            rBanca.GuardarBanca(banca);
            return banca;
        }

        //Busca una banca en el repositorio segun el DNI.
        public Banca BuscarBanca(string pDni)
        {
            Banca vBanca = rBanca.BuscarBanca(pDni);
            if(vBanca != null)
            {
                return vBanca;
            }
            else
            {
                return null;
            }
            
        }

        //Muestra en pantalla los datos de la banca.
        public void ConsultarBanca(Banca pBanca)
        {
            Console.WriteLine("Nombre y Apellido del Titular: " + pBanca.GetTitular());
            Console.WriteLine("DNI del Titular: " + pBanca.GetDniTitular());
            Console.WriteLine("Saldo actual en Pesos: " + pBanca.GetCuentaEnPesos().GetSaldo());
            Console.WriteLine("Saldo actual en Dolares: " + pBanca.GetCuentaEnDolares().GetSaldo());
        }

        //Acredita el saldo ingresado en la cuenta en pesos.
        public void AcreditarSaldoEnPesos(Cuenta pCuentaEnPesos, double pSaldo)
        {
            pCuentaEnPesos.AcreditarSaldo(pSaldo);
            Console.WriteLine("El saldo ha sido acreditado exitosamente");
        }

        //Acredita el saldo ingresado en la cuenta en dolares.
        public void AcreditarSaldoEnDolares(Cuenta pCuentaEnDolares, double pSaldo)
        {
            pCuentaEnDolares.AcreditarSaldo(pSaldo);
            Console.WriteLine("El saldo ha sido acreditado exitosamente.");
        }

        //Debita el monto ingresado de la cuenta en pesos y lo acredita en la cuenta en dolares solo si la cuenta en pesos tiene saldo suficiente para reliaza la operacion.
        public void AcreditarSaldoDePesoADolar(Cuenta pCuentaEnPesos, Cuenta pCuentaEnDolares, double pSaldo)
        {
            if (pCuentaEnPesos.DebitarSaldo(pSaldo))
            {
                pCuentaEnDolares.AcreditarSaldo(pSaldo / valorDolar);
            }
            else
            {
                Console.WriteLine("No hay saldo suficiente en la cuenta para realizar esta operacion.");
            }
        }

        //Debita el monto ingresado en la cuenta en doalres y lo acredita en la cuenta en pesos solo si la cuenta en dolares tiene saldo suficiente para hacerlo.
        public void AcreditarSaldoDeDolarAPeso(Cuenta pCuentaEnDolares, Cuenta pCuentaEnPesos, double pSaldo)
        {
            if (pCuentaEnDolares.DebitarSaldo(pSaldo))
            {
                pCuentaEnPesos.AcreditarSaldo(pSaldo * valorDolar);                              
            }
            else
            {
                Console.WriteLine("No hay saldo suficiente en la cuenta para realizar esta operacion.");
            }
        }

        //Debita el monto ingresado de la cuenta en Pesos solo si tiene saldo sufiente para hacerlo.
        public bool DebitarSaldoEnPesos(Cuenta pCuentaEnPesos, double pSaldo)
        {
            if (pCuentaEnPesos.DebitarSaldo(pSaldo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Debita el monto ingresado de la cuenta en Dolares solo si tiene saldo suficienta para hacerlo.
        public bool DebitarSaldoEnDolares(Cuenta pCuentaEnDolares, double pSaldo)
        {
            if (pCuentaEnDolares.DebitarSaldo(pSaldo))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
