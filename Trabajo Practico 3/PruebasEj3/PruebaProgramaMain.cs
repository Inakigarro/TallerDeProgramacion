using Ejercicio_3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace PruebasEj3
{
    public class PruebaProgramaMain
    {
        [Fact]
        public void PruebaCargaAleatoriaTurnos()
        {
            //Inicializacion del objeto de prueba.
            var facahda = new FachadaEj3();
            facahda.CargarSala(TipoSala.Consulta);
            facahda.CargarSala(TipoSala.Urgencias);

            for(int i = 0; i < 20; i++)
            {
                facahda.aListaPacientes.Add(new Paciente("nombre " + Convert.ToString(i), Convert.ToString(i), DateTime.Today, new Random().Next(1, 6)));
            }
            //Prueba del proceso de Carga aleatoria de objetos.
            facahda.CargaAleatoriaTurnos(facahda.aListaPacientes);
            var sala1 = facahda.aHospital.GetListaSalas.ElementAt(0);
            var sala2 = facahda.aHospital.GetListaSalas.ElementAt(1);
            //Verificacion del resultado.
            Assert.Equal(sala1.GetListaTurnos.Count, sala2.GetListaTurnos.Count);
        }
    }
}
