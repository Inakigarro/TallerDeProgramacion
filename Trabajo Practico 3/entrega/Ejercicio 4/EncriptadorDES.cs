using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Ejercicio_4
{
    public class EncriptadorDES : Encriptador
    {
        private string aClave = "a2V5Z2VuZXJhdG9y";
        private byte[] aClaveIV = Convert.FromBase64String("a2V5Z2VuZXJhdG9y");
        public EncriptadorDES() : base("DES")
        {
        }
        public override string Desencriptar(string pCadena)
        {
            //Codificando la cadena de entrada y la calve ingrasada en el constructor.
            byte[] vCadenaEncriptada = Convert.FromBase64String(pCadena);
            byte[] vClaveEncriptada = ASCIIEncoding.ASCII.GetBytes(aClave);

            //Inicializo el desencriptador.
            DESCryptoServiceProvider vDesencriptador = new DESCryptoServiceProvider();
            ICryptoTransform vTransformacion = vDesencriptador.CreateDecryptor(vClaveEncriptada, aClaveIV);
            CryptoStreamMode vModo = CryptoStreamMode.Write;

            //Desencriptando la cadena de entrada y la clave ingresada. 
            MemoryStream vStreamEnMemoria = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(vStreamEnMemoria, vTransformacion, vModo);
            cryptoStream.Write(vCadenaEncriptada, 0, vCadenaEncriptada.Length);
            cryptoStream.FlushFinalBlock();

            //Leemos la cadena desencriptada desde el stream en memoria.
            byte[] vArregloCadenaDesencriptada = new byte[vStreamEnMemoria.Length];
            vStreamEnMemoria.Position = 0;
            vStreamEnMemoria.Read(vArregloCadenaDesencriptada, 0, vArregloCadenaDesencriptada.Length);

            //Decodifico la cadena desencriptada.
            string vCadenaDesencriptadaSalida = Convert.ToBase64String(vArregloCadenaDesencriptada);

            return vCadenaDesencriptadaSalida;
        }

        public override string Encriptar(string pCadena)
        {
            //Codificando la cadena de entrada y la clave ingresada en el constructor.
            byte[] vCadenaEncriptada = ASCIIEncoding.ASCII.GetBytes(pCadena);
            byte[] vClaveEncriptada = Convert.FromBase64String(aClave);

            //Inicializacion el encriptador.
            DESCryptoServiceProvider vEncriptador = new DESCryptoServiceProvider();
            ICryptoTransform vTransformacion = vEncriptador.CreateEncryptor(vClaveEncriptada, aClaveIV);
            CryptoStreamMode vModo = CryptoStreamMode.Write;

            //Encriptando la cadena de entrada y la clave ingresada en el constructor.
            MemoryStream vStreamEnMemoria = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(vStreamEnMemoria, vTransformacion, vModo);
            cryptoStream.Write(vCadenaEncriptada, 0, vCadenaEncriptada.Length);
            cryptoStream.FlushFinalBlock();

            //Leemos la cadena encriptada desde el stream en memoria.
            byte[] vArregloCadenaEncriptada = new byte[vStreamEnMemoria.Length];
            vStreamEnMemoria.Position = 0;
            vStreamEnMemoria.Read(vArregloCadenaEncriptada, 0, vArregloCadenaEncriptada.Length);

            //Decodifico la cadena encriptada.
            string vCadenaEncriptadaSalida = Convert.ToBase64String(vArregloCadenaEncriptada);

            return vCadenaEncriptadaSalida;
        }
    }
}
