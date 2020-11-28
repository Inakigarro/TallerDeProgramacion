using Ejercicio_2;
using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;

namespace Ej2.Test
{
    public class PruebaEj2
    {
        [Fact]
        public void PruebaCreacionBanca()
        {
            //Inicializo el objeto de prueba.
            var fachada = new FachadaEjercicio2();

            //Prueba del metodo de creacion de una banca.
            string nombreApellidoTitular = "Iñaki Garro";
            string dni = "123456789";
            fachada.CrearBanca(nombreApellidoTitular, dni);

            //Verificacion del resultado.
            var banca = fachada.BuscarBanca(dni);
            Assert.NotNull(banca);
        }
        [Fact]
        public void PruebaAcreditacionSaldo()
        {
            //Inicializo el objeto de prueba.
            var fachada = new FachadaEjercicio2();
            string nombreApellido = "Iñaki Garro";
            string dni = "123456789";
            var banca = new Banca(nombreApellido, dni);

            //Pruebo el metodo de acreditacion de saldo.
            fachada.AcreditarSaldoEnPesos(banca.GetCuentaEnPesos(), 2500);
            fachada.AcreditarSaldoEnDolares(banca.GetCuentaEnDolares(), 1000);

            //Verificacion de resultado.
            Assert.Equal(2500, banca.GetCuentaEnPesos().GetSaldo());
            Assert.Equal(1000, banca.GetCuentaEnDolares().GetSaldo());
        }
        [Fact]
        public void PruebaAcreditacionSaldoDePesoADolar()
        {
            //Inicializo el objeto de prueba.
            var fachada = new FachadaEjercicio2();
            string nombreApellido = "Iñaki Garro";
            string dni = "123456789";
            var banca = new Banca(nombreApellido, dni);
            fachada.AcreditarSaldoEnPesos(banca.GetCuentaEnPesos(), 25000);
            fachada.AcreditarSaldoEnDolares(banca.GetCuentaEnDolares(), 10000);

            //Prueba del metodo de acrediacion de saldo, desde una cuenta en pesos a una en dolares.
            fachada.AcreditarSaldoDePesoADolar(banca.GetCuentaEnPesos(), banca.GetCuentaEnDolares(), 2500);


            //Verificacion del resultado.
            Assert.Equal(10000 + 25.85, banca.GetCuentaEnDolares().GetSaldo(), 2);
        }
        [Fact]
        public void PruebaAcreditacionDeDolarAPeso()
        {
            //Inicializo el objeto de prueba.
            var fachada = new FachadaEjercicio2();
            string nombreApellido = "Iñaki Garro";
            string dni = "123456789";
            var banca = new Banca(nombreApellido, dni);
            fachada.AcreditarSaldoEnPesos(banca.GetCuentaEnPesos(), 25000);
            fachada.AcreditarSaldoEnDolares(banca.GetCuentaEnDolares(), 10000);

            //Prueba del metodo de acreditacion desde una cuenta en dolares a una en pesos.
            fachada.AcreditarSaldoDeDolarAPeso(banca.GetCuentaEnDolares(), banca.GetCuentaEnPesos(), 1000);

            //Verificacion del resultado.
            Assert.Equal(25000 + 96694, banca.GetCuentaEnPesos().GetSaldo());
        }
    }
}
