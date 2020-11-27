using Ejercicio_4;
using System;
using Xunit;

namespace PruebasEj4
{
    public class PruebasEncriptadoresCesar
    {
        [Fact]
        public void PruebaEncriptarCadena()
        {
            //Inicializacion del objeto de prueba.
            var encriptador = new EncriptadorCesar(3);

            //Prueba del metodo encriptar.
            var cadenaSaliente = encriptador.Encriptar("Hola, Como estan?");

            //Verificacion del resultado.
            Assert.Equal("Krod/#Frpr#hvwdqB", cadenaSaliente);
        }
        [Fact]
        public void PruebaDesencriptarCadena()
        {
            //Inicializacion del obejto de prueba.
            var encriptador = new EncriptadorCesar(3);

            //Prueba del metodo desencriptar.
            var cadenaSaliente = encriptador.Desencriptar("Krod/#Frpr#hvwdqB");

            //Verificacion del resultado.
            Assert.Equal("Hola, Como estan?", cadenaSaliente);
        }
    }
}
