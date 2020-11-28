using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public  class Lista : IRepositorioUsuarios
    {
        private IList<Usuario> aLista = new List<Usuario>();
        public void Actualizar(Usuario pUsuario)
        {
            if (aLista.Contains(pUsuario))
            {
                var index = aLista.IndexOf(pUsuario);
                aLista[index] = pUsuario;
            }
        }

        public void Agregar(Usuario pUsuario)
        {
            aLista.Add(pUsuario);
        }

        public void Eliminar(string pCodigo)
        {
            Usuario vUsuario = new Usuario();
            vUsuario.Codigo = pCodigo;
            if (aLista.Contains(vUsuario))
            {
                foreach(Usuario u in aLista)
                {
                    if(u.Codigo == pCodigo)
                    {
                        aLista.Remove(u);
                    }
                }
            }
        }

        public IList<Usuario> ObtenerOrdenadosPor(IComparer<Usuario> pComparador)
        {
            Usuario[] lista = new Usuario[aLista.Count];
            aLista.CopyTo(lista, 0);
            var listaOrdenada = new List<Usuario>(lista);
            listaOrdenada.Sort(pComparador);
            return listaOrdenada;
        }

        public Usuario ObtenerPorCodigo(string pCodigo)
        {
            Usuario vUsuario = new Usuario();
            foreach(Usuario u in aLista)
            {
                if (u.Codigo.Equals(pCodigo)) vUsuario = u;
            }
            return vUsuario;
        }

        public IList<Usuario> ObtenerTodos()
        {
            Usuario[] lista = new Usuario[aLista.Count];
            aLista.CopyTo(lista, 0);
            return new List<Usuario>(lista);
        }
        public Usuario ObtenerPorParteCodigo(string pCodigo)
        {
            Usuario[] copiaLista = new Usuario[aLista.Count];
            aLista.CopyTo(copiaLista, 0);
            Usuario vUsuario = new Usuario();
            foreach(Usuario usuario in copiaLista)
            {
                if (usuario.Codigo.Contains(pCodigo))
                {
                    usuario.CopyTo(vUsuario);
                }
            }
            return vUsuario;
        }
    }
}
