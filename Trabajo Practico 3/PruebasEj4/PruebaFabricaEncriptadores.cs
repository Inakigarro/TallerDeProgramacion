using Ejercicio_4;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace PruebasEj4
{
    public class PruebaFabricaEncriptadores
    {
        [Fact]
        public void PruebaGetEncriptador()
        {
            //Inicializacion del objeto de prueba.
            var fabrica = new FabricaEncriptadores();

            //Prueba del metodo de obtencion de encriptadores.
            var encriptador = fabrica.GetEncriptador("SUP");

            //Verificacion del resultado.
            Assert.Equal("Nulo", encriptador.GetNombre());
        }
    }
}
