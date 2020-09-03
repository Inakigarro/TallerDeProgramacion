using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Cliente
    {
        //Atributos de un cliente.
        private string iNombre;
        private string iApellido;
        private string iDni;

        //Constructor de un cliente.
        public Cliente(string pNombre, string pApellido, string pDni)
        {
            iNombre = pNombre;
            iApellido = pApellido;
            iDni = pDni;
        }
        //setters de los atributos
        public void SetNombre(string pNombre)
        {
            iNombre = pNombre;
        }
        public void SetApellido(string pApellido)
        {
            iApellido = pApellido;
        }
        public void SetDni(string pDni)
        {
            iDni = pDni;
        }
            

        //Getters de los atributos.
        public string GetNombre()
        {
            return iNombre;
        }
        public string GetApellido()
        {
            return iApellido;
        }
        public string GetDni()
        {
            return iDni;
        } 
    }
}
