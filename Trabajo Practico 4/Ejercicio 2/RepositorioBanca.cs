using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    public class RepositorioBanca
    {
        //Atributos de la clase.
        private List<Banca> repositorioBanca;

        //Constructor de la clase.
        public RepositorioBanca()
        {
            repositorioBanca = new List<Banca>();
        }

        //Metodos de la clase.
        public void GuardarBanca(Banca pBanca)
        {
            repositorioBanca.Add(pBanca);
        }
        public Banca BuscarBanca(string pDniTitular)
        {
            Banca vBanca = repositorioBanca.Find(b => b.Dni.Equals(pDniTitular));
            if(vBanca == null)
            {
                throw new Exception("No existe una banca asociada al dato ingresado.");
            }
            return vBanca;
        }
    }
}
