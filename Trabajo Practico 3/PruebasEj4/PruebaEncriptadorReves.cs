using Ejercicio_4;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PruebasEj4
{
    public class PruebaEncriptadorReves
    {
        [Fact]
        public void PruebaEncriptarCadena()
        {
            //Inicializacion del objeto de prueba.
            var encriptador = new EncriptadorReves();

            //Prueba del metodo Encriptar.
            var cadenaEncriptada = encriptador.Encriptar("Una cadena desencriptada");

            //Verificacion del resutlad.
            Assert.Equal("adatpircnesed anedac anU", cadenaEncriptada);
        }
        [Fact]
        public void PruebaDesencriptarCadena()
        {
            //Inicializacion del objeto de prueba.
            var encriptador = new EncriptadorReves();

            //Prueba del metodo Encriptar.
            var cadenaEncriptada = encriptador.Encriptar("Una cadena desencriptada");
            var cadenaDesencriptada = encriptador.Desencriptar(cadenaEncriptada);

            //Verificacion del Resultado.
            Assert.Equal("Una cadena desencriptada", cadenaDesencriptada);
        }
    }
}
