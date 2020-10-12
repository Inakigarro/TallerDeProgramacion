using System;
using System.Collections.Generic;

namespace Trabajo_Practico_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var ArrayAnimales = new Animal[3];
            var perro = new Perro();
            var gato = new Gato();

            ArrayAnimales[0] = perro;
            ArrayAnimales[1] = gato;

            var veterinaria = new Veterinaria();
            veterinaria.AceptarAnimales(ArrayAnimales);
        }
    }
}
