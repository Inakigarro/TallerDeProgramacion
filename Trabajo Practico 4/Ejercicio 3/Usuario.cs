using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public class Usuario
    {
        //Atributos de la clase.
        string aCodigo;
        string aNombreCompleto;
        string aCorreoElectronico;

        //getters y setters de la clase.
        public string Codigo
        {
            get { return aCodigo; }
            set { aCodigo = value; }
        }
        public string NombreCompleto
        {
            get { return aNombreCompleto; }
            set { aNombreCompleto = value; }
        }
        public string CorreoElectronico
        {
            get { return aCorreoElectronico; }
            set { aCorreoElectronico = value; }
        }

        //Metodos de la clase.
        public override bool Equals(object obj)
        {
            bool resultado;
            if(obj == null)
            {
                resultado = false;
            }
            Usuario vUsuario = obj as Usuario;
            if(vUsuario == null)
            {
                resultado = false;
            }
            else
            {
                resultado = Equals(vUsuario);
            }
            return resultado;
        }
        public override int GetHashCode()
        {
            return int.Parse(aCodigo);
        }
        public bool Equals(Usuario pUsuario)
        {
            bool resultado;
            if(pUsuario == null)
            {
                resultado = false;
            }
            else
            {
                resultado = this.Codigo.Equals(pUsuario.Codigo);
            }
            return resultado;
        }
        public void CopyTo(Usuario pUsuario)
        {
            pUsuario.Codigo = this.Codigo;
            pUsuario.NombreCompleto = this.NombreCompleto;
            pUsuario.CorreoElectronico = this.CorreoElectronico;
        }

    }
}
