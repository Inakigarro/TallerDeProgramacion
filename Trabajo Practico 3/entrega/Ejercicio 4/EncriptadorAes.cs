using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace Ejercicio_4
{
    public class EncriptadorAes : Encriptador
    {
        //Atributos de la clase.
        private AesCryptoServiceProvider encriptador;

        //Constructor de la clase.
        public EncriptadorAes() : base ("AES")
        {
            encriptador = new AesCryptoServiceProvider();

            encriptador.BlockSize = 128;
            encriptador.KeySize = 256;
            encriptador.GenerateIV();
            encriptador.GenerateKey();
            encriptador.Mode = CipherMode.CBC;
            encriptador.Padding = PaddingMode.PKCS7;

        }

        public override string Desencriptar(string pCadena)
        {
            var vDesencriptador = encriptador.CreateDecryptor();
            byte[] cadenaEncriptada = Convert.FromBase64String(pCadena);
            byte[] cadenaDesencriptada = vDesencriptador.TransformFinalBlock(cadenaEncriptada, 0, cadenaEncriptada.Length);
            string cadenaSalida = ASCIIEncoding.ASCII.GetString(cadenaDesencriptada);
            return cadenaSalida;
        }

        public override string Encriptar(string pCadena)
        {
            var vEncriptador = encriptador.CreateEncryptor();
            byte[] cadenaEncriptada = vEncriptador.TransformFinalBlock(ASCIIEncoding.ASCII.GetBytes(pCadena), 0, pCadena.Length);

            string cadenaSalida = Convert.ToBase64String(cadenaEncriptada);
            return cadenaSalida;
        }
    }
}
