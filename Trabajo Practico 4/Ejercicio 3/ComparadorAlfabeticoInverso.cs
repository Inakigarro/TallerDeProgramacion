using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Ejercicio_3
{
    public class ComparadorAlfabeticoInverso : IComparer<Usuario>
    {
        public int Compare( Usuario x,  Usuario y)
        {
            return new CaseInsensitiveComparer().Compare(y.Codigo, x.Codigo);
        }
    }
}
