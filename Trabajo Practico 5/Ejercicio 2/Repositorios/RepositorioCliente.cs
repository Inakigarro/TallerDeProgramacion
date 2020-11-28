using Ejercicio_2.Controladores;
using Ejercicio_2.Controladores.Interfaces;
using Ejercicio_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Repositorios
{
    class RepositorioCliente : Repositorio<Cliente, AdministradorCuentasDbContext>, IClienteRepository
    {
        public RepositorioCliente(AdministradorCuentasDbContext pDbContext) : base(pDbContext) { }
    }
}
