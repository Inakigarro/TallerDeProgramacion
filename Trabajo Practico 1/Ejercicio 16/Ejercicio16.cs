using System;

namespace Ejercicio_16
{
    class Ejercicio16
    {
        static void Main(string[] args)
        {
            char caracterAContar;
            int cantidad = 0;
            int posicionCadena = 0;
            //Ingreso las cadenas por consola.
            Console.WriteLine("Ingrese la primer cadena.");
            string cadena1 = Console.ReadLine();

            Console.WriteLine("Ingrese la segunda cadena.");
            string cadena2 = Console.ReadLine();

            //Si las cadenas tienen distinto tamaño, no son anagramas.
            if(cadena1.Length != cadena2.Length)
            {
                Console.WriteLine("No son anagramas."); ;
            }
            //Si tienen el mismo tamaño, debo revisar si los caracteres de la primera cadena se encuentran en los caracteres de la segunda.
            else
            {
                //Recorro la primera cadena.
                while(posicionCadena < cadena1.Length)
                {
                    //Extraigo el caracter que voy a revisar.
                    caracterAContar = cadena1[posicionCadena];
                    //Cuento cuantas veces se encuentra ese caracter en la cadena
                    foreach(char c in cadena1)
                    {
                        if(c == caracterAContar)
                        {
                            cantidad++;
                        }
                    }
                    //Recorro la segunda cadena en busca de la misma cantidad de caracteres.
                    foreach(char c in cadena2)
                    {
                        while(cantidad != 0)
                        {
                            if(c == caracterAContar)
                            {
                                cantidad--;
                            }
                        }
                    }
                    //Si despues de recorrer la segunda cadena la cantidad es distinto de cero, entonces no son anagramas.
                    if(cantidad != 0)
                    {
                        Console.WriteLine("No son anagramas.");
                    }
                    //Si cantidad es cero, entonces adelanto una posicion en la cadena1 y repito el proceso.
                    else
                    {
                        posicionCadena++;
                    }

                }
                //Si luego de recorrer la primera cadena la cantidad es distinto de cero, entonces no son anagramas.
                if (cantidad != 0)
                {
                    Console.WriteLine("No son anagramas.");
                }
                //Si cantidad es cero, entonces son anagramas.
                else
                {
                    Console.WriteLine("Las cadenas son anagramas.");
                }
            } 
        }
    }
}
