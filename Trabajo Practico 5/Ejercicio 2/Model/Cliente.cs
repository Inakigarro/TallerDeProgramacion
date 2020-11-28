using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Model
{
    public class Cliente
    {
        //Atributos de la clase.
        public int ClienteId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Documento Documento { get; set; }
        public List<Cuenta> Cuentas { get; set; }
    }
}
