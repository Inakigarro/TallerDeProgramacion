using Ejercicio_1;
using System;
using Xunit;

namespace Ejercicio1.Test
{
    public class TrianguloTest
    {
        [Fact]
        public void Test1()
        {
            //creacion del triangulo de prueba.
            var pPunto1 = new Punto(1, 2);
            var pPunto2 = new Punto(5, 2);
            var pPunto3 = new Punto(3, 6);
            var triangulo = new Triangulo(pPunto1, pPunto2, pPunto3);

            //Pruebas
            var area = triangulo.Area();

            //Ni idea xd

            //base = 16
            //PuntoBase = 3, 2
            //Altura = (3 - 3) ^2 - (2 - 6)^2 
            Assert.Equal(128, area);
        }
    }
}
