using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using System.Threading;

namespace Ejercicio_4
{
    class Complejo
    {
        private double aReal;
        private double aImaginario;

        public Complejo(double pReal, double pImaginario)
        {
            aReal = pReal;
            aImaginario = pImaginario;
        }
        public double Real { get { return aReal; } }
        public double Imaginario { get { return aImaginario; } }
        public double ArgumentoEnGrados()
        {
            if(aReal == 0)
            {
                if (aImaginario == 0)
                {
                    return 0;
                }
                else if (aImaginario > 0)
                {
                    return 90;
                }
                else if (aImaginario < 0)
                {
                    return 270;
                }
            }
            return Math.Atan(aImaginario / aReal);
        }
        public double ArgumentoEnRadianes()
        {
            return ArgumentoEnGrados() * (Math.PI / 180);
        }
        public Complejo Conjugado()
        {
            var conjugado = new Complejo(aReal, -aImaginario);
            return conjugado;
        }
        public double Magnitud()
        {
             return Math.Sqrt(Math.Pow(aReal, 2) + Math.Pow(aImaginario, 2)); 
        }
        public Boolean EsReal()
        {
            if(Imaginario == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean EsImaginario()
        {
            if(Imaginario != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean EsIgual(Complejo pComplejo)
        {
            if (pComplejo.Real == this.Real && pComplejo.Imaginario == this.Imaginario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Boolean EsIgual(double pReal, double pImaginario)
        {
            if (pReal == this.aReal && pImaginario == this.aImaginario)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Complejo Sumar(Complejo pComplejo)
        {
            var vReal = this.Real + pComplejo.Real;
            var vImaginario = this.Imaginario + pComplejo.Imaginario;
            return new Complejo(vReal, vImaginario);
        }
        public Complejo Restar(Complejo pComplejo)
        {
            var vReal = this.Real - pComplejo.Real;
            var vImaginario = this.Imaginario - pComplejo.Imaginario;
            return new Complejo(vReal, vImaginario);
        }
        public Complejo MultiplicarPor(Complejo pComplejo)
        {
            Complex primerComplejo = new Complex(this.aReal, this.aImaginario);
            Complex segundoComplejo = new Complex(pComplejo.aReal, pComplejo.aImaginario);
            var resultadoComplejo = Complex.Multiply(primerComplejo, segundoComplejo);
            return new Complejo(resultadoComplejo.Real, resultadoComplejo.Imaginary);
        }
        public Complejo DividirPor(Complejo pComplejo)
        {
            var primerComplejo = new Complex(this.aReal, this.aImaginario);
            var segundoComplejo = new Complex(pComplejo.aReal, pComplejo.aImaginario);
            var resultadoComplejo = Complex.Divide(primerComplejo, segundoComplejo);
            return new Complejo(resultadoComplejo.Real, resultadoComplejo.Imaginary);
        }

    }
}
