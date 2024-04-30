using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class Calculadora
    {
        public int Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }

        public int Subtrair(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            return resultado;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            return resultado;
        }

        public int Dividir(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            return resultado;
        }

        public List<string> Historico()
        {
            return null;
        }
    }
}
