using Ejercicio_2.Controladores.Interfaces;
using Ejercicio_2.Model;
using Ejercicio_2.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Controladores
{
    public class UnidadDeTrabajo : IUnidadDeTrabajo
    {
        private AdministradorCuentasDbContext iDbContext;
        private ICuentaRepository cuentaRepository;
        private IClienteRepository clienteRepository;
        public UnidadDeTrabajo(AdministradorCuentasDbContext pDbContext)
        {
            iDbContext = pDbContext;
            cuentaRepository = new RepositorioCuenta(iDbContext);
            clienteRepository = new RepositorioCliente(iDbContext);
        }

        public AdministradorCuentasDbContext DbContext { get { return iDbContext; } }
        public ICuentaRepository CuentaRepositorio { get { return cuentaRepository; } }

        public IClienteRepository ClienteRepositorio { get { return clienteRepository; } }

        public void Complete()
        {
            iDbContext.SaveChanges();
        }

        public void Dispose()
        {
            iDbContext.Dispose();
        }
    }
}
