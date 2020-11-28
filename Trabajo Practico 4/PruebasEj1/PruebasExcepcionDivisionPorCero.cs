using Ejercicio_1;
using System;
using Xunit;

namespace PruebasEj1
{
    public class PruebasExcepcionDivisionPorCero
    {
        [Fact]
        public void PruebaMetodoDividir()
        {
            //Prueba del metodo de division.
            var resultado = Matematica.Dividir(10, 2);

            //Verificacion del resultado.
            Assert.Equal(5, resultado);
        }
        [Fact]
        public void PruebaExcepcionDivisionPorCero()
        {
            //Prueba del metodo de division.
            Action resutlado = () => Matematica.Dividir(10, 0);

            //Capturo la excepcion.
            DivisionPorCeroException excepcion = Assert.Throws<DivisionPorCeroException>(resutlado);

            //Verifico el resultado.
            Assert.Equal("No es posible realizar esta operación porque el divisor es Cero", excepcion.Message);
        }
    }
}
