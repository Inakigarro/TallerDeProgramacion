using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_2
{
    public class SaldoIncorrectoException : Exception
    {
        public SaldoIncorrectoException(string pMensaje) : base(pMensaje)
        {

        }
    }
}
