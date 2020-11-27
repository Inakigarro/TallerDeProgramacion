using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4
{
    public class FachadaEj4
    {
        private FabricaEncriptadores aFabricaEncriptadores = new FabricaEncriptadores();

        public string EncriptarCadena(string pNombreEncriptador, string pCadena)
        {
            IEncriptador vEncriptador = aFabricaEncriptadores.GetEncriptador(pNombreEncriptador);
            return vEncriptador.Encriptar(pCadena);
        }

        public string DesencriptarCadena(string pNombreEncriptador, string pCadena)
        {
            IEncriptador vEncriptador = aFabricaEncriptadores.GetEncriptador(pNombreEncriptador);
            return vEncriptador.Desencriptar(pCadena);
        }
    }
}
