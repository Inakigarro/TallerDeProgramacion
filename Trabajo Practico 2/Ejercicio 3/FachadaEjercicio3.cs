using System;

namespace Ejercicio_3
{
    class FachadaEjercicio3
    {
        HistorialPartidas hPartidas = new HistorialPartidas();
        Partida partida;


        public string GetPalabraElegida { get { return partida.PalabraElegida; } }
        public char[] GetPalabraFormada { get { return partida.PalabraFormada; } }
        public int GetVidas { get { return partida.Vidas; } }
        public string GetDificultad { get { return partida.Dificultad; } }

        public void CrearPartida(string pDificultad)
        {
            partida = new Partida(pDificultad);
            SetResultado("Iniciada");
        }
        public void GuardarPartida()
        {
            hPartidas.GuardarPartida(partida);
        }
        public void MostrarPalabraFormada()
        {
            foreach (char c in GetPalabraFormada)
            {
                if (c.Equals('\0'))
                {
                    Console.Write(" _ ");
                }
                else
                {
                    Console.Write(c);
                }
            }
        }
        public void GetLetrasIngresadas()
        {
            for (int i = 0; i < partida.LetrasIngresadas.Length; i++)
            {
                if (partida.LetrasIngresadas[i] != '\0')
                {
                    Console.Write(partida.LetrasIngresadas[i] + ", ");
                }
            }
        }
        public void GetInfoPartida()
        {
            //Pantalla de juego mientras estado de partida es 'Iniciada'
            if (partida.Resultado == "Iniciada")
            {
                Console.WriteLine("Dificultad: " + partida.Dificultad);
                Console.WriteLine("Vidas Restantes: " + GetVidas);
                Console.WriteLine("Longitud de la Palabra: " + GetPalabraElegida.Length);
                MostrarPalabraFormada();
                Console.WriteLine("");
                Console.Write("Letras Ingresadas: ");
                GetLetrasIngresadas();
            }
            //Pantalla de juego cuando estado de partida cambia a 'Victoria'
            else if (partida.Resultado == "Victoria")
            {
                Console.Clear();
                Console.WriteLine(" ----- VICTORIA ----- ");
                Console.WriteLine("Partida iniciada: " + partida.FechaInicio);
                Console.WriteLine("");
                Console.WriteLine("Dificultad: " + partida.Dificultad);
                Console.WriteLine("Vidas restantes: " + partida.Vidas);
                Console.WriteLine("La palabra era: " + new string(GetPalabraFormada));
                Console.Write("Letras usadas: " );
                GetLetrasIngresadas();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Partida finalizada: " + partida.FechaFin);
            }
            //Pantalla de juego cuando estadode partida cambia a 'Derrota'
            else if(partida.Resultado == "Derrota")
            {
                Console.Clear();
                Console.WriteLine(" ----- DERROTA ----- ");
                Console.WriteLine("Partida iniciada: " + partida.FechaInicio);
                Console.WriteLine("");
                Console.WriteLine("Dificultad: " + partida.Dificultad);
                Console.WriteLine("Vidas restantes: " + partida.Vidas);
                Console.WriteLine("La palabra era: " + partida.PalabraElegida);
                Console.Write("La palabra que formaste es: ");
                MostrarPalabraFormada();
                Console.WriteLine("");
                Console.Write("Letras usadas: ");
                GetLetrasIngresadas();
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Partida finalizada: " + partida.FechaFin);
            }


        }

        public void IngresarLetra(char pLetra)
        {
            partida.InsertarLetra(pLetra);
        }

        public void SetResultado(string pResultado)
        { 
            partida.Resultado = pResultado;
            partida.FechaFin = DateTime.Now;
        }
        public void JugarPartida()
        {
            //Mientras el resultado de la partida es 'Iniciada'
            while (GetPalabraElegida != new string(GetPalabraFormada) && GetVidas != 0)
            {
                Console.Clear();
                GetInfoPartida();
                Console.WriteLine("");
                Console.Write("Ingrese una letra: ");
                char vLetra = Convert.ToChar(Console.ReadLine());
                if (Char.IsLetter(vLetra))
                {
                    IngresarLetra(vLetra);
                }
            }
            //Cuando el resultado de la partida es 'Victoria'
            if(GetPalabraElegida == new string(GetPalabraFormada))
            {
                SetResultado("Victoria");
                GuardarPartida();
                GetInfoPartida();
                Console.ReadKey();

            }
            //Cuando el resultado de la partida es 'Derrota'
            else if(GetVidas == 0)
            {
                SetResultado("Derrota");
                GuardarPartida();
                GetInfoPartida();
                Console.ReadKey();
            }
        }
        public void MostrarHitorialPartidas()
        {
            foreach(Partida p in hPartidas.GetPartidas)
            {
                if(p != null)
                {
                    Console.WriteLine("--------------------------------------------------------------");
                    Console.WriteLine("Partida iniciada: " + partida.FechaInicio);
                    Console.WriteLine("");
                    Console.WriteLine(partida.Resultado);
                    Console.WriteLine("");
                    Console.WriteLine("Dificultad: " + partida.Dificultad);
                    Console.WriteLine("Vidas restantes: " + partida.Vidas);
                    Console.WriteLine("La palabra era: " + partida.PalabraElegida);
                    Console.Write("Letras usadas: ");
                    GetLetrasIngresadas();
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Partida finalizada: " + partida.FechaFin);
                }
            }
        }
    }
}
