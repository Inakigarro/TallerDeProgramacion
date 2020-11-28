using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class FachadaEj2
    {
        //Atributos de la clase.
        private RepositorioBanca aRepositorioBanca = new RepositorioBanca();
        //Metodos de la clase.
        public void CrearBanca(string pNombreApellidoTitular, string pDni)
        {
            Banca vBanca = new Banca(pNombreApellidoTitular, pDni);
            aRepositorioBanca.GuardarBanca(vBanca);
        }
        public Banca BuscarBanca(string pDniTituar)
        {
            return aRepositorioBanca.BuscarBanca(pDniTituar);
        }
        public void AcreditarSaldo(Cuenta pCuenta, double pSaldo)
        {
            pCuenta.AcreditarSaldo(pSaldo);
        }
        public void DebitarSaldo(Cuenta pCuenta, double pSaldo)
        {
            pCuenta.DebitarSaldo(pSaldo);
        }
        public void AcreditarSaldoDePesoADolar(Cuenta pCuentaEnPesos, Cuenta pCuentaEnDolares, double pSaldoEnPesos)
        {
            pCuentaEnPesos.DebitarSaldo(pSaldoEnPesos);
            pCuentaEnDolares.AcreditarSaldo(pSaldoEnPesos / (85.01 * 1.35) * 1.3); //Dolar oficial al dia 4/11/2020.
        }
        public void AcreditarSaldoDeDolarAPeso(Cuenta pCuentaEnDolares, Cuenta pCuentaEnPesos, double pSaldoEnDolares)
        {
            pCuentaEnDolares.DebitarSaldo(pSaldoEnDolares);
            pCuentaEnPesos.AcreditarSaldo(pSaldoEnDolares * 78.02); //Dolar oficial al dia 4/11/2020.
        }

    }
}
