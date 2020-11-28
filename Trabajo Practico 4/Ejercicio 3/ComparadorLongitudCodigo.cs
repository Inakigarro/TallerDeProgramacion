using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;

namespace Ejercicio_3
{
    public class ComparadorLongitudCodigo : IComparer<Usuario>
    {
        public int Compare( Usuario x, Usuario y)
        {
            if(x.Codigo.Length >= y.Codigo.Length)
            {
                return x.Codigo.Length;
            }
            else
            {
                return y.Codigo.Length;
            }
        }
    }
}
