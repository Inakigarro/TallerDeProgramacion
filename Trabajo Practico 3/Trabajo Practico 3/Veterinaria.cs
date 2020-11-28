using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Practico_3
{
    class Veterinaria
    {
        public void AceptarAnimales(Animal[] pListaAnimales)
        {
            foreach(Animal a in pListaAnimales)
            {
                a.HacerRuido();
            }
        }
    }
}
