using Ejercicio_4;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PruebasEj4
{
    public class PruebasEncriptadoresAES
    {
        [Fact]
        public void PruebaEncriptarCadena()
        {
            //Inicializacion del objeto de prueba.
            var encriptador = new EncriptadorAes();

            //Prueba del metodo encriptar.
            string cadenaSalida = encriptador.Encriptar("Hola, Como estan? ");

            //Verificacion del resultado.
            Assert.Equal("EbatNKeVUrMgvvTBi6p5x3Ed3TdMRjxc4xilT0Flk", cadenaSalida);
        }

        [Fact]
        public void PruebaEncriptarYDesencriptarCadena()
        {
            //Inicializacion del objeto de prueba.
            var encriptador = new EncriptadorAes();

            //Prueba del metodo encriptar.
            string cadenaEncriptada = encriptador.Encriptar("Hola, como estan?");
            string cadenaSalida = encriptador.Desencriptar(cadenaEncriptada);

            //Verificacion del resultado.
            Assert.Equal("Hola, como estan?", cadenaSalida);
        }
    }
}
