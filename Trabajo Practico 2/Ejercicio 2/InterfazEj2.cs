using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    class InterfazEj2
    {
        FachadaEjercicio2 fachada = new FachadaEjercicio2();

        //Menu Principal de la aplicación.
        public void MenuPrincipal()
        {
            string vNombreApellidoTitular;
            string vDniTitular;

            Console.Clear();
            Console.WriteLine(" --- Menu Principal --- ");
            Console.WriteLine("¿Que desea hacer?");
            Console.WriteLine("1 - Crear una Cuenta Bancaria");
            Console.WriteLine("2 - Buscar Cuenta existente.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            Console.WriteLine("");
            Console.WriteLine("Ingrese una opcion para continuar.");
            char opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    Console.WriteLine(" --- Crear una Cuenta Bancaria --- ");
                    Console.Write("Ingrese su Nombre y Apellido: ");
                    vNombreApellidoTitular = Console.ReadLine();
                    Console.Write("Ingrese su DNI. (Sin puntos. Solo Numeros)");
                    vDniTitular = Console.ReadLine();
                    fachada.CrearBanca(vNombreApellidoTitular, vDniTitular);
                    Console.WriteLine("Cuenta creada con exito.");
                    Console.WriteLine("Presione cualquier tecla para continuar.");
                    Console.ReadKey();
                    MenuPrincipal();
                    break;
                case '2':
                    Console.WriteLine(" --- Buscar una Cuenta existente --- ");
                    Console.Write("Ingrese su DNI. (Sin puntos.Solo Numeros)");
                    vDniTitular = Console.ReadLine();
                    Banca vBanca = fachada.BuscarBanca(vDniTitular);
                    if (vBanca != null)
                    {
                        MenuBanca(vBanca);
                    }
                    else
                    {
                        Console.Write("No existe una Banca Unificada con ese Numero. Presione una tecla para continuar.");
                        Console.ReadKey();
                        MenuPrincipal();
                    }
                    
                    break;
                case '0':
                    break;
                default:
                    Console.WriteLine("La opcion ingresada es incorrecta. Intente nuevamente.");
                    Console.ReadKey();
                    MenuPrincipal();
                    break;
            }
        }

        public void MenuBanca(Banca pBanca)
        {
            Console.Clear();
            Console.WriteLine(" --- Menu Banca --- ");
            fachada.ConsultarBanca(pBanca);
            Console.WriteLine("");
            Console.WriteLine("¿Con que cuenta desea trabajar?");
            Console.WriteLine("1 - Cuenta en Pesos.");
            Console.WriteLine("2 - Cuenta en Dolares.");
            Console.WriteLine("3 - Volver al Menu Principal.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            char opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    MenuCuenta(pBanca.GetCuentaEnPesos(), pBanca.GetCuentaEnDolares());
                    MenuBanca(pBanca);
                    break;
                case '2':
                    MenuCuenta(pBanca.GetCuentaEnDolares(), pBanca.GetCuentaEnPesos());
                    MenuBanca(pBanca);
                    break;
                case '3':
                    MenuPrincipal();
                    break;
                case '0':
                    break;
                default:
                    Console.WriteLine("La opcion ingresada es incorrecta. Intente nuevamente.");
                    Console.ReadKey();
                    MenuBanca(pBanca);
                    break;
            }
        }
        
        public void MenuCuenta(Cuenta pCuenta1, Cuenta pCuenta2)
        {
            Console.Clear();
            Console.WriteLine("1 - Consultar Saldo.");
            Console.WriteLine("2 - Acreditar Saldo.");
            Console.WriteLine("3 - Acreditar Saldo desde la cuenta en dolares.");
            Console.WriteLine("4 - Debitar Saldo.");
            Console.WriteLine("");
            Console.WriteLine("0 - Salir.");
            Console.Write("Ingrese una opcion para continuar: ");
            char opcion = Convert.ToChar(Console.ReadLine());
            switch (opcion)
            {
                case '1':
                    Console.Clear();
                    Console.WriteLine("El saldo actual de la cuenta es: " + pCuenta1.GetSaldo());
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                    MenuCuenta(pCuenta1, pCuenta2);
                    break;
                case '2':
                    Console.Clear();
                    Console.Write("Ingrese el monto que desea acreditar: ");
                    double vSaldo = double.Parse(Console.ReadLine());
                    pCuenta1.AcreditarSaldo(vSaldo);
                    Console.WriteLine("Operacion exitosa.");
                    Console.WriteLine("Presione una tecla para continuar.");
                    Console.ReadKey();
                    MenuCuenta(pCuenta1, pCuenta2);
                    break;
                case '3':
                    Console.Clear();
                    Console.Write("Ingrese el monto en pesos que desea acreditar: ");
                    vSaldo = double.Parse(Console.ReadLine());
                    if(pCuenta1.GetMoneda() == "ARS")
                    {
                        if (pCuenta2.DebitarSaldo(vSaldo / fachada.ValorDolar))
                        {
                            pCuenta1.AcreditarSaldo(vSaldo);
                            Console.WriteLine("Operación realizada con exito.");
                            Console.WriteLine("Presione una tecla para continuar.");
                            Console.ReadKey();
                            MenuCuenta(pCuenta1, pCuenta2);
                        }
                        else
                        {
                            Console.WriteLine("No hay saldo suficiente en la cuenta elegida para realizar esta operacion.");
                            Console.WriteLine("Presione una tecla para continuar.");
                            Console.ReadKey();
                            MenuCuenta(pCuenta1, pCuenta2);
                        }
                    }
                    else
                    {
                        if (pCuenta2.DebitarSaldo(vSaldo * fachada.ValorDolar))
                        {
                            pCuenta1.AcreditarSaldo(vSaldo);
                            Console.WriteLine("Operación realizada con exito.");
                            Console.WriteLine("Presione una tecla para continuar.");
                            Console.ReadKey();
                            MenuCuenta(pCuenta1, pCuenta2);
                        }
                        else
                        {
                            Console.WriteLine("No hay saldo suficiente en la cuenta elegida para realizar esta operacion.");
                            Console.WriteLine("Presione una tecla para continuar.");
                            Console.ReadKey();
                            MenuCuenta(pCuenta1, pCuenta2);
                        }
                    }
                    

                    break;
                case '4':
                    Console.Clear();
                    Console.Write("Ingrese el saldo que desea debitar: ");
                    vSaldo = double.Parse(Console.ReadLine());
                    if (fachada.DebitarSaldoEnPesos(pCuenta1, vSaldo))
                    {
                        Console.WriteLine("Saldo debitado con exito.");
                        Console.Write("Presione una tecla para continuar: ");
                        Console.ReadKey();
                        MenuCuenta(pCuenta1, pCuenta2);
                    }
                    else
                    {
                        Console.WriteLine("La cuenta no tiene saldo suficiente para realizar esta operacion.");
                        Console.Write("Presione una tecla para continuar: ");
                        Console.ReadKey();
                        MenuCuenta(pCuenta1, pCuenta2);
                    }
                    break;
            }
        }
    }
}
