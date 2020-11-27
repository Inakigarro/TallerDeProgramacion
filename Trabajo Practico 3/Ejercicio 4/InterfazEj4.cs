using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4
{
    class InterfazEj4
    {
        FachadaEj4 aFachada = new FachadaEj4();
        public void MenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("Elija con que encriptador desea trabajar:");
            Console.WriteLine(" 1 - Cesar");
            Console.WriteLine(" 2 - AES");
            Console.WriteLine(" 3 - DES");
            Console.WriteLine(" 4 - Reves");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Salir");
            Console.Write("Ingrese una opcion para continuar: ");
            var opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    MenuEncriptacion("Cesar");
                    break;
                case 2:
                    MenuEncriptacion("AES");
                    break;
                case 3:
                    MenuEncriptacion("DES");
                    break;
                case 4:
                    MenuEncriptacion("Reves");
                    break;
                default:
                    break;
            }
        }

        public void MenuEncriptacion(string pNombreEncriptacion)
        {
            Console.Clear();
            Console.WriteLine("¿Que accion desea realizar?");
            Console.WriteLine(" 1 - Encriptar.");
            Console.WriteLine(" 2 - Desencriptar.");
            Console.WriteLine("");
            Console.WriteLine(" 0 - Volver.");
            Console.Write("Ingrese una opcion para continuar: ");
            var opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    Console.Write("Ingrese la cadena a encriptar: ");
                    var cadenaAEncriptar = Console.ReadLine();
                    Console.Write("La cadena encriptada es: " + aFachada.EncriptarCadena(pNombreEncriptacion, cadenaAEncriptar));
                    break;
                case 2:
                    Console.Write("Ingrese la cadena a desencriptar: ");
                    var cadenaADesencriptar = Console.ReadLine();
                    Console.Write("La cadena encriptada es: " + aFachada.EncriptarCadena(pNombreEncriptacion, cadenaADesencriptar));
                    break;
                default:                                          
                    break;
            }
        }
    }
}
