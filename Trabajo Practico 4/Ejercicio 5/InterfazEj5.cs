using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class InterfazEj5
    {
        public void MenuPrincipal()
        {
            FachadaEj5 fachada = new FachadaEj5();
            //Solicitud de ingresos de datos del cliente.
            Console.WriteLine("");
            Console.WriteLine("----- o ----- o -----");
            Console.WriteLine("");
            Console.WriteLine("Ingrese los datos del cliente: ");
            Console.Write("Nombre: ");
            string vNombreCliente = Console.ReadLine();
            Console.Write("Apellido: ");
            string vApellidoCliente = Console.ReadLine();
            Console.Write("Fecha de nacimiento (DD - MM - AAAA): " );
            DateTime vFechaNacimientoCliente = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("----- o ----- o -----");
            Console.WriteLine("");
            Console.WriteLine("Ingrese los siguientes datos pertinentes al empleo del cliente: ");
            Console.Write("Fecha de ingreso (DD - MM - AAAA): ");
            DateTime vFechaIngresoEmpleoCliente = DateTime.Parse(Console.ReadLine());
            Console.Write("Saldo: ");
            double vSaldoEmpleoCliente = double.Parse(Console.ReadLine());
            Console.WriteLine("");
            Console.WriteLine("----- o ----- o -----");
            Console.WriteLine("");
            Console.WriteLine("Seleccione el tipo de cliente");
            Console.WriteLine(" 1 - No cliente.");
            Console.WriteLine(" 2 - Cliente.");
            Console.WriteLine(" 3 - Cliente Gold.");
            Console.WriteLine(" 4 - Cliente Platinum.");
            Console.Write("Opcion: ");
            TipoCliente vTipoCliente = TipoCliente.NoCliente;
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    vTipoCliente = TipoCliente.NoCliente;
                    break;
                case 2:
                    vTipoCliente = TipoCliente.Cliente;
                    break;
                case 3:
                    vTipoCliente = TipoCliente.ClienteGold;
                    break;
                case 4:
                    vTipoCliente = TipoCliente.ClientePlatinum;
                    break;
            }
            Empleo vEmpleoCliente = fachada.CrearEmpleo(vSaldoEmpleoCliente, vFechaIngresoEmpleoCliente);
            Cliente vCliente = fachada.CrearCliente(vNombreCliente, vApellidoCliente, vFechaNacimientoCliente, vEmpleoCliente, vTipoCliente);
            Console.Clear();
            MostrarDatosClientes(vCliente);

            //Ingreso de datos de la solicitud de prestamo.
            Console.Write("Ingrese el monto a solicitar: ");
            double vMontoPrestamo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de cuotas: ");
            int vCantidadCuotasPrestamo = int.Parse(Console.ReadLine());
            SolicitudPrestamo vSolicitudPrestamo = fachada.CrearSolicitudPrestamo(vCliente, vMontoPrestamo, vCantidadCuotasPrestamo);
            Console.Clear();
            MostrarDatosSolicitudPrestamos(vSolicitudPrestamo);
            Console.ReadKey();

            //Verificacion de la solicitud.
            if (fachada.ValidarSolicitudPrestamo(vSolicitudPrestamo))
            {
                Console.WriteLine("El prestamo ha sido aprobado.");
            }
            else
            {
                Console.WriteLine("El prestamo ha sido rechazado.");
            }
        }
        public void MostrarDatosClientes(Cliente pCliente)
        {
            Console.WriteLine("");
            Console.WriteLine("----- o ----- o -----");
            Console.WriteLine("");
            Console.WriteLine("Nombre: " + pCliente.Nombre);
            Console.WriteLine("Apellido: " + pCliente.Apellido);
            Console.WriteLine("Fecha de nacimiento: " + pCliente.FechaNacimiento.ToString());
            Console.WriteLine("Fecha de ingreso al empleo: " + pCliente.Empleo.FechaIngreso.ToString());
            Console.WriteLine("Sueldo: " + pCliente.Empleo.Sueldo);
            Console.WriteLine("Tipo cliente: " + pCliente.TipoCliente);
            Console.WriteLine("");
            Console.WriteLine("----- o ----- o -----");
            Console.WriteLine("");
        }
        public void MostrarDatosSolicitudPrestamos(SolicitudPrestamo pSolicitudPrestamo)
        {
            Console.WriteLine("");
            Console.WriteLine("----- o ----- o -----");
            Console.WriteLine("");
            Console.WriteLine("Nombre completo del cliente: " + pSolicitudPrestamo.Cliente.Nombre + " " + pSolicitudPrestamo.Cliente.Apellido);
            Console.WriteLine("Monto solicitado: " + pSolicitudPrestamo.Monto);
            Console.WriteLine("Cantidad de Cuotas: " + pSolicitudPrestamo.CantidadCuotas);
            Console.WriteLine("");
            Console.WriteLine("----- o ----- o -----");
            Console.WriteLine("");
        }
    }
}
