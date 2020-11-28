using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class Matematica
    {
        public static double Dividir(double pDividendo, double pDivisor)
        {
            double resultado;
            if (pDivisor == 0)
            {
                throw new DivisionPorCeroException("No es posible realizar esta operación porque el divisor es Cero");
            }
            else
            {
                resultado = pDividendo / pDivisor;
            }
            return resultado;
        }
    }
}
