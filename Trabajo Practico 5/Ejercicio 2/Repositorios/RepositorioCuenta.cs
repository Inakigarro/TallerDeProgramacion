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
    class RepositorioCuenta: Repositorio<Cuenta, AdministradorCuentasDbContext>, ICuentaRepository
    {
        public RepositorioCuenta(AdministradorCuentasDbContext pDbContext) : base(pDbContext) { }

        public IEnumerable<Cuenta> ObtenerCuentasSobregiradas()
        {
            List<Cuenta> cuentasSobregiradas = new List<Cuenta>();
            foreach (Cuenta cuenta in iDbContext.Cuentas)
            {
                if(cuenta.GetBalance() < cuenta.Descubierto)
                {
                    cuentasSobregiradas.Add(cuenta);
                }
            }
            return cuentasSobregiradas;
        }
    }
}
