using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    class InterfazEj1
    {
        private FachadaEj1 fachada = new FachadaEj1(); 
        public void MenuPrincipal()
        {
            Console.Write("Ingrese el dividendo: ");
            double dividendo = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el divisor: ");
            double divisor = double.Parse(Console.ReadLine());
            try
            {
                Console.WriteLine("El resultado es: " + fachada.Dividir(dividendo, divisor));
            }
            catch(DivisionPorCeroException excepcion)
            {
                Console.WriteLine(excepcion.Message);
            }
        }
    }
}
