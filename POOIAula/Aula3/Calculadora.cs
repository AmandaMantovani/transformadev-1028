using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    internal class Calculadora
    {
        public double numero1;
        public double numero2;
        
        internal Calculadora()
        {
        }

        internal Calculadora(double numero1)
        {
            this.numero1 = numero1;
        }

        internal Calculadora(double numero1, double numero2)
        {
            this.numero1 = numero1;
            this.numero2 = numero2;
        }

        public double Somar()
        {
            return numero1 + numero2;
        }

        public static double Somar(List<double> valores)
        {
            return valores.Sum();
        }

        public double Subtrair()
        {
            return numero1 - numero2;
        }

        public double Multiplicar()
        {
            return numero1 * numero2;
        }

        public double? Dividir()
        {
            if (numero2 == 0)
            {
                return null;
            }

            return numero1 / numero2;
        }

    }
}
