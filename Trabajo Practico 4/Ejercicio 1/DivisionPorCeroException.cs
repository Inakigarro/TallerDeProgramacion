using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_1
{
    public class DivisionPorCeroException : Exception
    {
        public DivisionPorCeroException(string pCadena) : base(pCadena)
        {
            
        }
    }
}
