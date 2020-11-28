using Ejercicio_2;
using System;
using Xunit;

namespace PruebasEj2
{
    public class PruebasEjercicio2
    {
        [Fact]
        public void PruebaAcreditarSaldo()
        {
            //Creacion de los objetos de prueba.
            Banca banca = new Banca("Iñaki Garro", "37338575");

            //Prueba del proceso de acreditacion de saldo para una cuenta.
            Action resultado = () => banca.CuentaEnDolares.AcreditarSaldo(0);

            //Capturo la excepcion.
            SaldoIncorrectoException exception = Assert.Throws<SaldoIncorrectoException>(resultado);

            //Verifico el resultado.
            Assert.Equal("El saldo ingresado no es correcto.", exception.Message);
        }
        [Fact]
        public void PruebaDebitarsaldo()
        {
            //Creacion de los objetos de prueba.
            Banca banca = new Banca("Iñaki Garro", "37338575");

            //Prueba del proceso de debitar el saldo ingresado.
            banca.CuentaEnPesos.AcreditarSaldo(300);
            Action resultado = () => banca.CuentaEnPesos.DebitarSaldo(400);

            //Capturo la excepcion.
            SaldoIncorrectoException exception = Assert.Throws<SaldoIncorrectoException>(resultado);

            //Verifico el resultado.
            Assert.Equal("Saldo insuficiente para realizar esta operación", exception.Message);
        }
    }
}
