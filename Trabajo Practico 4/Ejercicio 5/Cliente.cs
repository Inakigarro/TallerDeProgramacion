using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public enum TipoCliente { NoCliente, Cliente, ClienteGold, ClientePlatinum}
    public class Cliente
    {
        //Atributos de la clase.
        private string aNombre;
        private string aApellido;
        private DateTime aFechaNacimiento;
        private Empleo aEmpleo;
        private TipoCliente aTipoCliente;

        //Constructor de la clase.
        public Cliente(string pNombre, string pApellido, Empleo pEmpleo, DateTime pFechaNacimiento)
        {
            aNombre = pNombre;
            aApellido = pApellido;
            aFechaNacimiento = pFechaNacimiento;
            aEmpleo = pEmpleo;
        }

        //Getters y Setters de la clase.
        public string Nombre { get { return aNombre; } }
        public string Apellido { get { return aApellido; } }
        public DateTime FechaNacimiento { get { return aFechaNacimiento; } }
        public Empleo Empleo { get { return aEmpleo; } }
        public TipoCliente TipoCliente
        {
            get { return aTipoCliente; }
            set { aTipoCliente = value; }
        }
    }
}
