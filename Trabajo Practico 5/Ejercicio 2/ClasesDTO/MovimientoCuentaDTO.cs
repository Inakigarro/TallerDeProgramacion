using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.ClasesDTO
{
    class MovimientoCuentaDTO
    {
        public int MovimientoCuentaId { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; }
        public double Monto { get; set; }
    }
}
