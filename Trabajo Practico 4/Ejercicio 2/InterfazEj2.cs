using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace Ejercicio_2
{
    class InterfazEj2
    {
        FachadaEj2 fachadaEj2 = new FachadaEj2();
        public void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine(" --- Menu Principal --- ");
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1 - Crear una Cuenta Bancaria");
            Console.WriteLine("2 - Buscar Cuenta existente.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            Console.WriteLine("");
            Console.WriteLine("Ingrese una opcion para continuar.");
            var opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    MenuCreacionBanca();
                    break;
                case 2:
                    AdministracionBanca();
                    break;

            }
        }
        public void MenuCreacionBanca()
        {
            Console.WriteLine(" --- Crear una Cuenta Bancaria --- ");
            Console.Write("Ingrese su Nombre y Apellido: ");
            string vNombreApellidoTitular = Console.ReadLine();
            Console.Write("Ingrese su DNI. (Sin puntos. Solo Numeros)");
            string vDniTitular = Console.ReadLine();
            fachadaEj2.CrearBanca(vNombreApellidoTitular, vDniTitular);
            Console.WriteLine("Cuenta creada con exito.");
            Console.WriteLine("Presione cualquier tecla para continuar.");
            Console.ReadKey();
            MenuPrincipal();
        }
        public void AdministracionBanca()
        {
            Console.WriteLine(" --- Administración de Cuenta Bancaria --- ");
            Console.WriteLine("");
            Console.WriteLine("Ingrese su DNI. (Solo numeros. Sin puntos.)");
            string vDni = Console.ReadLine();
            try
            {
                 Banca vBanca = fachadaEj2.BuscarBanca(vDni);
                Console.WriteLine("Titular: " + vBanca.Titular);
                Console.WriteLine("Saldo en pesos: " + vBanca.CuentaEnPesos.Saldo);
                Console.WriteLine("Saldo en dolares: " + vBanca.CuentaEnDolares.Saldo);
                MenuAdministracionBanca(vBanca);
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
            Console.Clear();
            
        }
        public void MenuAdministracionBanca(Banca pBanca)
        {
            Console.WriteLine("--- --- --- --- --- --- ---");
            Console.WriteLine("¿Sobre que cuenta desea trabajar?");
            Console.WriteLine(" 1 - Cuenta en Pesos.");
            Console.WriteLine(" 2 - Cuenta en Dolares.");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Volver al menu anterior.");
            Console.WriteLine("--- --- --- --- --- --- ---");
            Console.Write("Ingrese una opcion para continuar: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    MenuAdministracionCuenta(pBanca.CuentaEnPesos, pBanca.CuentaEnDolares);
                    MenuAdministracionBanca(pBanca);
                    break;
                case 2:
                    MenuAdministracionCuenta(pBanca.CuentaEnDolares, pBanca.CuentaEnPesos);
                    MenuAdministracionBanca(pBanca);
                    break;
                case 0:
                    MenuPrincipal();
                    break;
                default:
                    Console.WriteLine("La opcion ingresada no es correcta. Intente nuevamente.");
                    Console.ReadKey();
                    Console.Clear();
                    MenuAdministracionBanca(pBanca);
                    break;
            }
        }
        public void MenuAdministracionCuenta(Cuenta pCuentaPrincipal, Cuenta pCuentaSecundaria)
        {
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine(" 1 - Acreditar saldo de forma directa.");
            Console.WriteLine(" 2 - Acreditar saldo desde otra cuenta.");
            Console.WriteLine(" 3 - Debitar saldo.");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Volver al menu anterior.");
            Console.Write("Ingrese una opcion para continuar: ");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese el monto que desea acreditar: ");
                    double vMonto = double.Parse(Console.ReadLine());
                    try
                    {
                        fachadaEj2.AcreditarSaldo(pCuentaPrincipal, vMonto);
                    }
                    catch(SaldoIncorrectoException excepcion)
                    {
                        Console.WriteLine(excepcion.Message);
                    }
                    Console.WriteLine("Saldo acreditado con exito.");
                    break;
                case 2:
                    Console.Write("Ingrese el monto que desea acreditar: ");
                    double vMontoAcreditar = double.Parse(Console.ReadLine());
                    try
                    {
                        if (pCuentaPrincipal.Moneda.CodigoISO.Equals("ARS"))
                        {
                            fachadaEj2.AcreditarSaldoDePesoADolar(pCuentaPrincipal, pCuentaSecundaria, vMontoAcreditar);
                        }
                        else
                        {
                            fachadaEj2.AcreditarSaldoDeDolarAPeso(pCuentaPrincipal, pCuentaSecundaria, vMontoAcreditar);
                        }
                    }catch(SaldoIncorrectoException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                    Console.WriteLine("Saldo acreditado con exito.");
                    break;
                case 3:
                    Console.Write("Ingrese el monto que desea debitar: ");
                    double vMontoDebitar = double.Parse(Console.ReadLine());
                    try
                    {
                        fachadaEj2.DebitarSaldo(pCuentaPrincipal, vMontoDebitar);
                    }
                    catch(SaldoIncorrectoException exception)
                    {
                        Console.WriteLine(exception.Message);
                    }
                    Console.WriteLine("Saldo debitado con exito.");
                    break;
                case 0:
                    break;
                default:
                    Console.WriteLine("La opcion ingresada no es correcta. Intente nuevamente.");
                    Console.ReadKey();
                    Console.Clear();
                    MenuAdministracionCuenta(pCuentaPrincipal, pCuentaSecundaria);
                    break;
            }
        }
    }
}
