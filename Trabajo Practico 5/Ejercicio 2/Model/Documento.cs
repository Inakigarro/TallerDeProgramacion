using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Model
{
    public enum TipoDocumento { DNI, CUIL, LE, LC }
    public class Documento
    {
        //Atributos de la clase.
        public int DocumentoId { get; set; }
        public string Numero { get; set; }
        public TipoDocumento Tipo { get; set; }
    }
}
