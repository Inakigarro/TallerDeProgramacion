using Ejercicio_2.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Controladores
{
    public class AdministradorCuentasDbContext : DbContext
    {
        public AdministradorCuentasDbContext() : base("name=TallerDeProgramacion") { }
        
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Cuenta> Cuentas { get; set; }
        public DbSet<MovimientoCuenta> MovimientoCuentas { get; set; }
    }
}
