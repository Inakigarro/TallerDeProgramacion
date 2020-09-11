using Ejercicio_2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ejercicio_2
{
    class RepositorioBanca
    {
        //Atributos de la clase.
        private Banca[] repositorioBanca;
        
        //Constructor de la clase.
        public RepositorioBanca()
        {
            repositorioBanca = new Banca[10];
        }
       
        //Guarda una Banca en el arreglo.
        public void GuardarBanca(Banca pBanca)
        {
            for (int i = 0; i<10; i++)
            {
                if (repositorioBanca[i] == null)
                {
                    repositorioBanca[i] = pBanca;
                }
            }
            //repositorioBanca.Append(pBanca);
        }

        //Busca una Banca en el arreglo utilizando el DNI del titular.
        public Banca BuscarBanca(string pDniTitular)
        {
            foreach(Banca banca in repositorioBanca)
            {
                if (banca.GetDniTitular() == pDniTitular)
                {
                    return banca;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
    }
}
