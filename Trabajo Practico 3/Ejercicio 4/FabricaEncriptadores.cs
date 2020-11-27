using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_4
{
    public sealed class FabricaEncriptadores
    {
        //Atributos de la clase.
        private static FabricaEncriptadores aFabricaEncriptadores = null;
        private static readonly object padlock = new object();
        private List<IEncriptador> aListaEncriptador = new List<IEncriptador>();
        private IEncriptador aEncriptadorNulo = new EncriptadorNulo();

        //Constructor de la clase.
        public FabricaEncriptadores()
        {
            aListaEncriptador.Add(new EncriptadorCesar(3));
            aListaEncriptador.Add(new EncriptadorAes());
            aListaEncriptador.Add(new EncriptadorDES());
            aListaEncriptador.Add(new EncriptadorReves());
        }

        //Getters de la clase.
        public static FabricaEncriptadores Instancia
        {
            get
            {
                lock (padlock)
                {
                    if (aFabricaEncriptadores == null)
                    {
                        aFabricaEncriptadores = new FabricaEncriptadores();
                    }
                }
                return aFabricaEncriptadores;
            }
        }

        //Metodos de la clase.
        public IEncriptador GetEncriptador(string pNombre)
        {
            IEncriptador encriptador = null;
            encriptador = aListaEncriptador.Find(e => e.GetNombre() == pNombre);

            if(encriptador == null)
            {
                encriptador = aEncriptadorNulo;
            }
            return encriptador;
        }
    }
}
