using Ejercicio_2.ClasesDTO;
using Ejercicio_2.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_2.Controladores
{
    class FachadaBanco
    {
        public IEnumerable<CuentaDTO> GetCuentaDeCliente(int pClienteId)
        {
            List<CuentaDTO> cuentas = new List<CuentaDTO>();
            using (var db = new AdministradorCuentasDbContext())
            {
                var cliente = db.Clientes.Find(pClienteId);
                foreach (Cuenta cuenta in cliente.Cuentas)
                {
                    var cuentaDTO = new CuentaDTO
                    {
                        CuentaId = cuenta.CuentaId,
                        Nombre = cuenta.Nombre,
                        Descubierto = cuenta.Descubierto,
                        Balance = cuenta.GetBalance()
                    };
                    cuentas.Add(cuentaDTO);
                }
            }
            return cuentas;
        }
        public IEnumerable<MovimientoCuentaDTO> GetMovimientoCuentas(int pCuentaId)
        {
            List<MovimientoCuentaDTO> movimientos = new List<MovimientoCuentaDTO>();
            using (var db = new AdministradorCuentasDbContext())
            {
                Cuenta cuenta = db.Cuentas.Find(pCuentaId);
                foreach(MovimientoCuenta movimiento in cuenta.Movimientos)
                {
                    MovimientoCuentaDTO movimientoDTO = new MovimientoCuentaDTO
                    {
                        MovimientoCuentaId = movimiento.MovimientoCuentaId,
                        Fecha = movimiento.Fecha,
                        Descripcion = movimiento.Descripcion,
                        Monto = movimiento.Monto
                    };
                    movimientos.Add(movimientoDTO);
                }
            }
            return movimientos;
        }
    }
}
