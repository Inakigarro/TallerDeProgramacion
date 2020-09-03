using Ejercicio_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ejercicio_2
{
    class Repositorios
    {
        Banca[] aBanca = new Banca[1];
        Banca[] aBanca2;

        
        public void AgregarBanca(Banca pBanca)
        {
            aBanca2 = new Banca[aBanca.Length + 1];
            if(aBanca.Count() == aBanca.Length)
            {
                aBanca2
            }
            aBanca.Append(pBanca);
        }

    }
}
