using System;
using System.Collections.Generic;
using System.Text;

namespace TDD
{
    public class Calculadora
    {
        private List<string> _historico = new List<string>();

        public int Somar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            AdicionarAoHistorico($"{numero1} + {numero2} = {resultado}");

            return resultado;
        }

        public int Subtrair(int numero1, int numero2)
        {
            int resultado = numero1 - numero2;
            AdicionarAoHistorico($"{numero1} - {numero2} = {resultado}");

            return resultado;
        }

        public int Multiplicar(int numero1, int numero2)
        {
            int resultado = numero1 * numero2;
            AdicionarAoHistorico($"{numero1} * {numero2} = {resultado}");

            return resultado;
        }

        public int Dividir(int numero1, int numero2)
        {
            int resultado = numero1 / numero2;
            AdicionarAoHistorico($"{numero1} / {numero2} = {resultado}");

            return resultado;
        }

        public List<string> Historico()
        {
            return null;
        }

        private void AdicionarAoHistorico(string operacao)
        {
            _historico.Insert(0, operacao);

            if (_historico.Count > 3)
            {
                _historico.RemoveAt(3);
            }
        }
    }
}
