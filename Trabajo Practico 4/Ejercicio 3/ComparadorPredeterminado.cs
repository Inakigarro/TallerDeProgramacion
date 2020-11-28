using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_3
{
    public class ComparadorPredeterminado : IComparer<Usuario>
    {
        public int Compare(Usuario x,Usuario y)
        {
            return new CaseInsensitiveComparer().Compare(x.Codigo, y.Codigo);
        }
    }
}
