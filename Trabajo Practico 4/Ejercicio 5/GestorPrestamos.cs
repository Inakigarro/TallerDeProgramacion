using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicio_5
{
    public class GestorPrestamos
    {
        //Atributos de la clase.
        private Dictionary<TipoCliente, EvaluadorCompuesto> aDiccionario = new Dictionary<TipoCliente, EvaluadorCompuesto>();

        //Constructor de la clase.
        public GestorPrestamos()
        {
            //Evaluador para tipo no cliente.
            EvaluadorCompuesto evaluadorNoCliente = new EvaluadorCompuesto();
            evaluadorNoCliente.AgregarEvaluador(new EvaluadorMonto(20000));
            evaluadorNoCliente.AgregarEvaluador(new EvaluadorCantidadCuotas(12));
            evaluadorNoCliente.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
            evaluadorNoCliente.AgregarEvaluador(new EvaluadorEdad(18, 75));
            evaluadorNoCliente.AgregarEvaluador(new EvaluadorSueldo(5000));
            aDiccionario.Add(TipoCliente.NoCliente, evaluadorNoCliente);

            //Evaluador para tipo cliente.
            EvaluadorCompuesto evaluadorCliente = new EvaluadorCompuesto();
            evaluadorCliente.AgregarEvaluador(new EvaluadorMonto(100000));
            evaluadorCliente.AgregarEvaluador(new EvaluadorCantidadCuotas(32));
            evaluadorCliente.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
            evaluadorCliente.AgregarEvaluador(new EvaluadorEdad(18, 75));
            evaluadorCliente.AgregarEvaluador(new EvaluadorSueldo(5000));
            aDiccionario.Add(TipoCliente.Cliente, evaluadorCliente);

            //Evaluador para tipo cliente Gold.
            EvaluadorCompuesto evaluadorClienteGold = new EvaluadorCompuesto();
            evaluadorClienteGold.AgregarEvaluador(new EvaluadorMonto(150000));
            evaluadorClienteGold.AgregarEvaluador(new EvaluadorCantidadCuotas(60));
            evaluadorClienteGold.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
            evaluadorClienteGold.AgregarEvaluador(new EvaluadorEdad(18, 75));
            evaluadorClienteGold.AgregarEvaluador(new EvaluadorSueldo(5000));
            aDiccionario.Add(TipoCliente.ClienteGold, evaluadorClienteGold);

            //Evaluador para tipo cliente Platinum.
            EvaluadorCompuesto evaluadorClientePlatinum = new EvaluadorCompuesto();
            evaluadorClientePlatinum.AgregarEvaluador(new EvaluadorMonto(200000));
            evaluadorClientePlatinum.AgregarEvaluador(new EvaluadorCantidadCuotas(60));
            evaluadorClientePlatinum.AgregarEvaluador(new EvaluadorAntiguedadLaboral(6));
            evaluadorClientePlatinum.AgregarEvaluador(new EvaluadorEdad(18, 75));
            evaluadorClientePlatinum.AgregarEvaluador(new EvaluadorSueldo(5000));
            aDiccionario.Add(TipoCliente.ClientePlatinum, evaluadorClientePlatinum);
        }

        //Metodos de la clase.
        public bool EsValida(SolicitudPrestamo pSolicitudPrestamo)
        {
            var evaluador = aDiccionario[pSolicitudPrestamo.Cliente.TipoCliente];
            bool resultado = evaluador.EsValida(pSolicitudPrestamo);
            return resultado;
        }
    }
}
