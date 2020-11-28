using Ejercicio_2.Controladores;
using Ejercicio_2.Model;
using Ejercicio_2.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2
{
    class FachadaEj2
    {
        //Clientes
        public void AgregarCliente(Cliente pCliente)
        {
            var unidadDeTrabajo = new UnidadDeTrabajo(new AdministradorCuentasDbContext());
            using (unidadDeTrabajo.DbContext)
            {
                unidadDeTrabajo.ClienteRepositorio.Agregar(pCliente);
                unidadDeTrabajo.Complete();
            }
        }
        public Cliente ObtenerCliente(int pClienteId)
        {
            var unidadDeTrabajo = new UnidadDeTrabajo(new AdministradorCuentasDbContext());
            var cliente = new Cliente();
            using (unidadDeTrabajo.DbContext)
            {
                cliente = unidadDeTrabajo.ClienteRepositorio.Obtener(pClienteId);
                unidadDeTrabajo.Complete();
            }
            return cliente;
        }
        public IEnumerable<Cliente> ObtenerTodosLosClientes()
        {
            var unidadDeTrabajo = new UnidadDeTrabajo(new AdministradorCuentasDbContext());
            using (unidadDeTrabajo.DbContext)
            {
                var lista = unidadDeTrabajo.ClienteRepositorio.ObtenerTodos();
                unidadDeTrabajo.Complete();
                return lista;
            }
        }
        public void EliminarCliente(Cliente pCliente)
        {
            var unidadDeTrabajo = new UnidadDeTrabajo(new AdministradorCuentasDbContext());
            using (unidadDeTrabajo.DbContext)
            {
                unidadDeTrabajo.ClienteRepositorio.Eliminar(pCliente);
                unidadDeTrabajo.Complete();
            }
        }

        //Cuentas
        public void AgregarCuenta(Cuenta pCuenta)
        {
            var unidadDeTrabajo = new UnidadDeTrabajo(new AdministradorCuentasDbContext());
            using (unidadDeTrabajo.DbContext)
            {
                unidadDeTrabajo.CuentaRepositorio.Agregar(pCuenta);
                unidadDeTrabajo.Complete();
            }
        }
        public Cuenta ObtenerCuenta(int pCuentaId)
        {
            var unidadDeTrabajo = new UnidadDeTrabajo(new AdministradorCuentasDbContext());
            var cliente = new Cuenta();
            using (unidadDeTrabajo.DbContext)
            {
                cliente = unidadDeTrabajo.CuentaRepositorio.Obtener(pCuentaId);
                unidadDeTrabajo.Complete();
            }
            return cliente;
        }
        public IEnumerable<Cuenta> ObtenerTodasLasCuentas()
        {
            var unidadDeTrabajo = new UnidadDeTrabajo(new AdministradorCuentasDbContext());
            using (unidadDeTrabajo.DbContext)
            {
                var lista = unidadDeTrabajo.CuentaRepositorio.ObtenerTodos();
                unidadDeTrabajo.Complete();
                return lista;
            }
        }
        public void EliminarCuenta(Cuenta pCuenta)
        {
            var unidadDeTrabajo = new UnidadDeTrabajo(new AdministradorCuentasDbContext());
            using (unidadDeTrabajo.DbContext)
            {
                unidadDeTrabajo.CuentaRepositorio.Eliminar(pCuenta);
                unidadDeTrabajo.Complete();
            }
        }

    }
}
