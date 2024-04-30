using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class Calculadora
    {
        public int Somar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Subtrair(int numero1, int numero2)
        {
            return numero1 - numero2;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            return numero1 * numero2;
        }

        public int Dividir(int numero1, int numero2)
        {
            return numero1 / numero2;
        }

        public List<string> Historico()
        {
            return null;
        }
    }
}
