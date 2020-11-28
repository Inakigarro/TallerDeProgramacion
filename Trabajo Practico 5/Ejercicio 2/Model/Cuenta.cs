using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Model
{
    public class Cuenta
    {
        //Atributos de la clase.
        public int CuentaId { get; set; }
        public string Nombre { get; set; }
        public double Descubierto { get; set; }
        public IList<MovimientoCuenta> Movimientos { get; set; }

        //Metodos de la clase.
        public double GetBalance()
        {
            double balance = 0;
            foreach (MovimientoCuenta movimiento in Movimientos)
            {
                balance += movimiento.Monto;
            }
            return balance;
        }
        public IEnumerable<MovimientoCuenta> GetUltimosMovimientos(int cantidad = 7)
        {
            List<MovimientoCuenta> ultimosMovimientos = new List<MovimientoCuenta>();
            for(int i = 0; i < cantidad; i++)
            {
                ultimosMovimientos.Add(Movimientos.ElementAt(i));
            }
            return ultimosMovimientos;
        }
        public void AgregarMovimiento(MovimientoCuenta pMovimiento)
        {
            Movimientos.Add(pMovimiento);
            Movimientos.OrderByDescending(m => m.Fecha);
        }
    }
}
