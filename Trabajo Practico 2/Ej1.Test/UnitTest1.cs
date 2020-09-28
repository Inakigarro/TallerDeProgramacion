using System;
using Xunit;
using Ejercicio_1;

namespace Ej1.Test
{
    public class UnitTest1
    {
        [Fact]
        public void Test_AreaCirculo_CaminoCorrecto()
        {
            //Inicializacion del objeto de prueba.
            var circulo = new Circulo(0, 0, 5);

            //Prubea del metodo Area.
            var area = circulo.CalcularAreaCirculo;

            //Verificacion del resultado.
            Assert.Equal(78.54, area, 2);
        }
        [Fact]
        public void Test_AreaTriangulo_CaminoCorrecto()
        {
            //Inicializacion del objeto de prueba.
            var punto1 = new Punto(0, 1);
            var punto2 = new Punto(4, 1);
            var punto3 = new Punto(2, 4);
            var triangulo = new Triangulo(punto1, punto2, punto3);

            //Prueba del metodo Area.
            var area = triangulo.CalcularAreaTriangulo();

            //Verificacion del resultado.
            Assert.Equal(125, area);
        }
        [Fact]
        public void Test_PerimetroCirculo_CaminoCorrecto()
        {
            //Inicializacion del objeto de prueba.
            var circulo = new Circulo(0, 0, 5);

            //Prueba del metodo Perimetro.
            var perimetroCirculo = circulo.CalcularPerimetroCirculo;

            //Verificacion del resultado.
            Assert.Equal(31.4, perimetroCirculo, 1);

        }
        [Fact]
        public void Test_PerimetroTriangulo_CaminoCorrecto()
        {
            //Inicializacion del objeto de prueba.
            var punto1 = new Punto(0, 1);
            var punto2 = new Punto(4, 1);
            var punto3 = new Punto(2, 4);
            var triangulo = new Triangulo(punto1, punto2, punto3);

            //Prueba del metodo Perimetro.
            var perimetroTriangulo = triangulo.CalcularPerimetroTriangulo();

            //Verificacion del resultado.
            Assert.Equal(42, perimetroTriangulo, 1);
        }
    }
}
