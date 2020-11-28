using Ejercicio_3;
using System;
using System.Collections.Generic;
using Xunit;

namespace PruebasEj3
{
    public class PruebasEj3
    {
        [Fact]
        public void PruebaAgregarUsuarioDiccionario()
        {
            //Creacion de los objetos de prueba.
            Usuario usuario = new Usuario();
            usuario.Codigo = "Codigo 1";
            usuario.NombreCompleto = "Nombre Completo";
            usuario.CorreoElectronico = "Correo@Electronico.com";

            IRepositorioUsuarios repositorio = new Diccionario();

            //Prueba del metodo de agregar un usuario.
            repositorio.Agregar(usuario);

            //Verificacion del resultado.
            Assert.True(repositorio.ObtenerTodos().Count > 0);
        }

        [Fact]
        public void PruebaBuscarUsuarioDiccionario()
        {
            //Creacion de los objetos de prueba.
            Usuario usuario1 = new Usuario();
            usuario1.Codigo = "Codigo 1";
            usuario1.NombreCompleto = "Nombre Completo";
            usuario1.CorreoElectronico = "Correo@Electronico.com";

            Usuario usuario2 = new Usuario();
            usuario2.Codigo = "Codigo 2";
            usuario2.NombreCompleto = "Nombree Completoo";
            usuario2.CorreoElectronico = "Correo2@Electronico2.com";

            IRepositorioUsuarios repositorio = new Diccionario();
            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);

            //Prueba del metodo de busqueda de usuarios.
            Usuario usuarioEncontrado = repositorio.ObtenerPorCodigo(usuario1.Codigo);

            Assert.Equal(usuarioEncontrado.Codigo, usuario1.Codigo);
        }
        [Fact]
        public void PruebaOrdenamientoDiccionario()
        {
            //Creacion de los objetos de prueba.
            Usuario usuario1 = new Usuario();
            usuario1.Codigo = "CodigoZaky";
            usuario1.NombreCompleto = "Iñaki Garro";
            usuario1.CorreoElectronico = "Correo@Electronico.com";

            Usuario usuario2 = new Usuario();
            usuario2.Codigo = "CodigoPana";
            usuario2.NombreCompleto = "Gaston Rodriguez";
            usuario2.CorreoElectronico = "Correo2@Electronico2.com";

            Usuario usuario3 = new Usuario();
            usuario3.Codigo = "CodigoJP";
            usuario3.NombreCompleto = "Juan Pedro Caffa";
            usuario3.CorreoElectronico = "Correo2@Electronico2.com";

            IRepositorioUsuarios repositorio = new Diccionario();
            repositorio.Agregar(usuario3);
            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);

            //Prueba del proceso de ordenamiento.
            IList<Usuario> lista = repositorio.ObtenerOrdenadosPor(new ComparadorAlfabeticoInverso());

            //Verificacion del resultado.
            var listaOriginal = repositorio.ObtenerTodos();
            Assert.False(listaOriginal.Equals(lista));
        }
        [Fact]
        public void PruebaActualizarUsuarioDiccionario()
        {
            //creacion de los objetos de prueba.
            Usuario usuario1 = new Usuario();
            usuario1.Codigo = "CodigoZaky";
            usuario1.NombreCompleto = "Iñaki Garro";
            usuario1.CorreoElectronico = "Correo@Electronico.com";

            Usuario usuario2 = new Usuario();
            usuario2.Codigo = "CodigoZaky";
            usuario2.NombreCompleto = "Gaston Rodriguez";
            usuario2.CorreoElectronico = "Correo2@Electronico2.com";

            IRepositorioUsuarios repositorio = new Diccionario();
            repositorio.Agregar(usuario1);

            //Prueba del metodo actualizar.
            Usuario usuarioPreActualizacion = repositorio.ObtenerPorCodigo("CodigoZaky");
            repositorio.Actualizar(usuario2);
            Usuario usuarioPostActualizacion = repositorio.ObtenerPorCodigo("CodigoZaky");

            //Verificacion del resultado.
            Assert.False(usuarioPreActualizacion.NombreCompleto.Equals(usuarioPostActualizacion.NombreCompleto));
        }
        [Fact]
        public void PruebaAgregarUsuarioLista()
        {
            //Creacion de los objetos de prueba.
            Usuario usuario = new Usuario();
            usuario.Codigo = "Codiigo";
            usuario.NombreCompleto = "Esto es un nombre";
            usuario.CorreoElectronico = "EstoEs@UnCorreo.com";

            IRepositorioUsuarios repositorio = new Lista();

            //Prueba del metodo de agregar un usuario al repositorio.
            repositorio.Agregar(usuario);

            //Verificacion del resutlado.
            Assert.True(repositorio.ObtenerTodos().Count > 0);
        }
        [Fact]
        public void PruebaActualizarUsuarioLista()
        {
            //creacion de los objetos de prueba.
            Usuario usuario1 = new Usuario();
            usuario1.Codigo = "CodigoZaky";
            usuario1.NombreCompleto = "Iñaki Garro";
            usuario1.CorreoElectronico = "Correo@Electronico.com";

            Usuario usuario2 = new Usuario();
            usuario2.Codigo = "CodigoZaky";
            usuario2.NombreCompleto = "Gaston Rodriguez";
            usuario2.CorreoElectronico = "Correo2@Electronico2.com";

            IRepositorioUsuarios repositorio = new Lista();
            repositorio.Agregar(usuario1);

            //Prueba del metodo actualizar.
            Usuario usuarioPreActualizacion = repositorio.ObtenerPorCodigo("CodigoZaky");
            repositorio.Actualizar(usuario2);
            Usuario usuarioPostActualizacion = repositorio.ObtenerPorCodigo("CodigoZaky");

            //Verificacion del resultado.
            Assert.False(usuarioPreActualizacion.NombreCompleto.Equals(usuarioPostActualizacion.NombreCompleto));
        }
        [Fact]
        public void PruebaBuscarUsuarioLista()
        {
            //Creacion de los objetos de prueba.
            Usuario usuario1 = new Usuario();
            usuario1.Codigo = "Codigo 1";
            usuario1.NombreCompleto = "Nombre Completo";
            usuario1.CorreoElectronico = "Correo@Electronico.com";

            Usuario usuario2 = new Usuario();
            usuario2.Codigo = "Codigo 2";
            usuario2.NombreCompleto = "Nombree Completoo";
            usuario2.CorreoElectronico = "Correo2@Electronico2.com";

            IRepositorioUsuarios repositorio = new Lista();
            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);

            //Prueba del metodo de busqueda de usuarios.
            Usuario usuarioEncontrado = repositorio.ObtenerPorCodigo(usuario1.Codigo);

            Assert.Equal(usuarioEncontrado.Codigo, usuario1.Codigo);
        }
        [Fact]
        public void PruebaOrdenamientoLista()
        {
            //Creacion de los objetos de prueba.
            Usuario usuario1 = new Usuario();
            usuario1.Codigo = "CodigoZaky";
            usuario1.NombreCompleto = "Iñaki Garro";
            usuario1.CorreoElectronico = "Correo@Electronico.com";

            Usuario usuario2 = new Usuario();
            usuario2.Codigo = "CodigoPana";
            usuario2.NombreCompleto = "Gaston Rodriguez";
            usuario2.CorreoElectronico = "Correo2@Electronico2.com";

            Usuario usuario3 = new Usuario();
            usuario3.Codigo = "CodigoJP";
            usuario3.NombreCompleto = "Juan Pedro Caffa";
            usuario3.CorreoElectronico = "Correo2@Electronico2.com";

            IRepositorioUsuarios repositorio = new Lista();
            repositorio.Agregar(usuario3);
            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);

            //Prueba del proceso de ordenamiento.
            IList<Usuario> lista = repositorio.ObtenerOrdenadosPor(new ComparadorAlfabeticoInverso());

            //Verificacion del resultado.
            var listaOriginal = repositorio.ObtenerTodos();
            Assert.False(listaOriginal.Equals(lista));
        }
        [Fact]
        public void ObtenerPorParteCodigoLista()
        {
            //Inicializacion de los objetos de prueba.
            Usuario usuario1 = new Usuario();
            usuario1.Codigo = "CodigoZaky";
            usuario1.NombreCompleto = "Iñaki Garro";
            usuario1.CorreoElectronico = "Correo@Electronico.com";

            Usuario usuario2 = new Usuario();
            usuario2.Codigo = "CodigoPana";
            usuario2.NombreCompleto = "Gaston Rodriguez";
            usuario2.CorreoElectronico = "Correo2@Electronico2.com";

            IRepositorioUsuarios repositorio = new Lista();
            repositorio.Agregar(usuario1);
            repositorio.Agregar(usuario2);

            //Prueba del metodo ObtenerPorParteCodigo.
            Usuario usuarioEncontrado = new Usuario();
            repositorio.ObtenerPorParteCodigo("Zaky").CopyTo(usuarioEncontrado);

            //Verificacion del resultado.
            Assert.Equal(usuario1, usuarioEncontrado);
        }
    }
}
