using Ejercicio_4;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PruebasEj4
{
    public class PruebasEncriptadoresDES
    {
        [Fact]
        public void PruebaEncriptarCadena()
        {
            //Inicializacion del objeto de prueba.
            var encriptador = new EncriptadorDES();

            //Prueba del metodo encriptar.
            string cadenaSalida = encriptador.Encriptar("Cadena desencriptada");

            //Verificacion del resultado.
            Assert.Equal("Cadena Encriptada", cadenaSalida);
        }

        [Fact]
        public void PruebaDesencriptarCadena()
        {
            //Inicializacion del objeto de prueba.
            var encriptador = new EncriptadorDES();

            //Prueba del metodo encriptar.
            string cadenaEncriptada = encriptador.Encriptar("Cadena Desencriptada");
            string cadenaSalida = encriptador.Desencriptar(cadenaEncriptada);

            //Verificacion del resultado.
            Assert.Equal("Cadena desencriptada", cadenaSalida);
        }
    }
}
