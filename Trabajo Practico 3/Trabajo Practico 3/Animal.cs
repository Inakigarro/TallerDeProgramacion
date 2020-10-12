using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Practico_3
{
    abstract class Animal
    {

        public  void Correr()
        {
            Console.WriteLine("Corriendo");
        }
        public void Saltar()
        {
            Console.WriteLine("Saltando");
        }
        public abstract void HacerRuido();

    }
}
