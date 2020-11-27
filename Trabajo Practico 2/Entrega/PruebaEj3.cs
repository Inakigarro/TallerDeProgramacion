using System;
using Xunit;
using Ejercicio_3;
using System.Linq;

namespace Ej3.Test
{
    public class PruebaEj3
    {
        [Fact]
        public void PruebaCreacionPartida()
        {
            //Inicializacion del Objeto de Prueba.
            var historialPartidas = new RepositorioPartidas();

            //Prueba del proceso de creacion de una partida.
            int dificultad = 2;
            string nombre = "Zaky";
            historialPartidas.CrearPartida(dificultad, nombre);

            //Verificacion del resultado.
            //Si el repositorio de partidas no esta vacio, entonces la partida se creo correctamente.
            Assert.True(historialPartidas.GetPartidas.Count != 0);
        }

        [Fact]
        public void PruebaIngresoDeLetra()
        {
            //Inicializacion del objeto de Prueba.
            var repositorioPartida = new RepositorioPartidas();

            //Prueba del proceso de inscercion de una letra a la partida.
            int dif = 2;
            string nombre = "Zaky";
            repositorioPartida.CrearPartida(dif, nombre);
            char letra = 'l';
            repositorioPartida.InsertarLetra(letra);

            //Verificacion del resultado.
            //Si la lista de letras ingresadas no esta vacia, entonces la letra se ingreso correctamente. 
            var partida = repositorioPartida.CargarPartdaEnCurso();
            Assert.True(partida.GetLetrasIngresadas.Count != 0);
        }
        [Fact]
        public void PruebaVictoriaPartida()
        {
            //Inicializacion del objeto de Prueba.
            var repositorioPartida = new RepositorioPartidas();

            //Prueba del proceso de victoria de una partida.
            //Creo una partida con nivel de dificultad 1.
            int dif = 1;
            string nombre = "Zaky";
            repositorioPartida.CrearPartida(dif, nombre);
            //Busco la partida recien creada, ya que estara 'En Curso', para obtener la palabra que salio elegida aleatoriamente.
            var partidaEnCurso = repositorioPartida.CargarPartdaEnCurso();
            //Cargo, letra por letra, la palabra elegida para forzar la victoria.
            foreach(char c in partidaEnCurso.GetPalabraElegida)
            {
                repositorioPartida.InsertarLetra(c);
            }
            partidaEnCurso = repositorioPartida.CargarPartdaEnCurso();
            if (partidaEnCurso.GetPalabraElegida.Equals(new string(partidaEnCurso.GetPalabraFormada)))
            {
                repositorioPartida.SetVictoria();
            }
            else
            {
                repositorioPartida.SetDerrota();
            }
            //Verificacion del Resultado.
            var partida = repositorioPartida.GetPartidas.First();
            Assert.Equal(Convert.ToString(Resultado.Victoria), partida.GetResultado);

        }

        [Fact]
        public void PruebaDerrotaPartida()
        {
            //Inicializacion del objeto de Prueba.
            var repositorioPartida = new RepositorioPartidas();

            //Prueba del proceso de victoria de una partida.
            //Creo una partida con nivel de dificultad 3, para disminuir la cantidad de vidas.
            int dif = 3;
            string nombre = "Zaky";
            repositorioPartida.CrearPartida(dif, nombre);
            //Busco la partida recien creada, ya que estara 'En Curso', para obtener la palabra que salio elegida aleatoriamente.
            var partidaEnCurso = repositorioPartida.CargarPartdaEnCurso();
            while(partidaEnCurso.GetVidas != 0)
            {
                repositorioPartida.InsertarLetra('a');
            }
            //Actualizo los datos de la partida.
            partidaEnCurso = repositorioPartida.CargarPartdaEnCurso();
            if(!partidaEnCurso.GetPalabraElegida.Equals(new string(partidaEnCurso.GetPalabraFormada)))
            {
                repositorioPartida.SetDerrota();
            }

            //Verificacion del resultado.
            var partida = repositorioPartida.GetPartidas.First();
            Assert.Equal(Convert.ToString(Resultado.Derrota), partida.GetResultado);
        }
    }
}
