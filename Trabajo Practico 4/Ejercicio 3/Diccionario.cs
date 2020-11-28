using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejercicio_3
{
    public class Diccionario : IRepositorioUsuarios
    {
        //Atributos de la clase.
        private IDictionary<string,Usuario> aDiccionario = new Dictionary<string, Usuario>();

        //Metodos de la clase.
        public void Agregar(Usuario pUsuario)
        {
            aDiccionario.Add(pUsuario.Codigo, pUsuario);
        }

        public void Eliminar(string pCodigo)
        {
            aDiccionario.Remove(pCodigo);
        }

        public IList<Usuario> ObtenerTodos()
        {
             List<Usuario> lista = aDiccionario.Values.ToList();
            return lista;
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            Usuario vUsuario = aDiccionario[pCodigo];
            return vUsuario;
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            List<Usuario> lista = aDiccionario.Values.ToList();
            lista.Sort(pComparador);
            return lista;
        }

        public void Actualizar(Usuario pUsuario)
        {
            aDiccionario[pUsuario.Codigo] = pUsuario;
        }

        public Usuario ObtenerPorParteCodigo(string pCodigo)
        {
            var claves = aDiccionario.Keys;
            Usuario vUsuario = new Usuario();
            foreach(string clave in claves)
            {
                if (clave.Contains(pCodigo))
                {
                    this.ObtenerPorCodigo(clave).CopyTo(vUsuario);
                }
            }
            return vUsuario;
        }
    }
}
