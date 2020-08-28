using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class Cliente
    {
        //Atributos de un cliente.
        private string nombre;
        private string apellido;
        private string dni;

        //Constructor de un cliente.
        public Cliente(string iNombre, string iApellido, string iDni)
        {
            nombre = iNombre;
            apellido = iApellido;
            dni = iDni;
        }

        //Getters de los atributos.
        public string GetNombre()
        {
            return nombre;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public string GetDni()
        {
            return dni;
        } 
    }
}
