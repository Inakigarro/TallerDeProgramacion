using Ejercicio_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Controladores.Interfaces
{
    public interface ICuentaRepository : IRepository<Cuenta> 
    {
        IEnumerable<Cuenta> ObtenerCuentasSobregiradas();
    }
}
