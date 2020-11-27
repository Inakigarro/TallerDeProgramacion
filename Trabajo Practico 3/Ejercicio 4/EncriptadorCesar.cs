using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_4
{
    public class EncriptadorCesar : Encriptador
    {
        //Atributos de la clase.
        private int aDesplazamiento;

        //Constructor de la clase.
        public EncriptadorCesar(int pDesplazamiento) : base("Cesar")
        {
            aDesplazamiento = pDesplazamiento;
        }
        
        //Metodos de la clase.
        public override string Desencriptar(string pCadena)
        {
            byte[] cadenaEntrante = Encoding.ASCII.GetBytes(pCadena);
            char[] cadenaSaliente = new char[pCadena.Length];
            for (int i = 0; i < cadenaSaliente.Length; i++)
            {
                cadenaSaliente[i] = Convert.ToChar(cadenaEntrante[i] - aDesplazamiento);
            }
            return new string(cadenaSaliente);
        }
        public override string Encriptar(string pCadena)
        {
            
            byte[] cadenaEntrante = Encoding.ASCII.GetBytes(pCadena);
            char[] cadenaSaliente = new char[pCadena.Length];
            for(int i = 0; i < cadenaSaliente.Length; i++)
            {
                cadenaSaliente[i] =  Convert.ToChar(cadenaEntrante[i] + aDesplazamiento);
            }
            return new string(cadenaSaliente);
        }
    }
}
