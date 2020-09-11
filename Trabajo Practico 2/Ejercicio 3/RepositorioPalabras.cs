using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Ejercicio_3
{
    class RepositorioPalabras
    {
        string[] repositorioPalabras =  {"mueble", "cama", "computadora", "colonia", "teclado",
                                         "lampara", "cocina", "camioneta", "pileta", "pelota",
                                         "sillon", "pantalla", "espejo", "biblioteca", "perfume",
                                         "cuadro", "pintura", "heladera", "televisor", "trabajo",
                                         "avenida", "celular", "ventilador", "cuaderno", "maestro",
                                         "espacio", "netflix", "escalera", "puerta", "familia"};

        public string ElegirPalabra()
        {
            var rnd = new Random();
            int posicion = rnd.Next(repositorioPalabras.Length);
            return repositorioPalabras[posicion];
        }
    }
}
