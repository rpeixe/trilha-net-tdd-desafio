using System;
using Xunit;
using TDD;
using System.Collections.Generic;

namespace TDD.Tests
{
    public class CalculadoraTest
    {
        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(1, -2, -1)]
        [InlineData(1, 0, 1)]
        public void Somar_DoisNumeros_RetornaSoma(int numero1, int numero2, int resultadoEsperado)
        {
            var calculadora = new Calculadora();

            int resultado = calculadora.Somar(numero1, numero2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(1, -2, 3)]
        [InlineData(1, 0, 1)]
        public void Subtrair_DoisNumeros_RetornaSubtracao(int numero1, int numero2, int resultadoEsperado)
        {
            var calculadora = new Calculadora();

            int resultado = calculadora.Subtrair(numero1, numero2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(1, -2, -2)]
        [InlineData(1, 0, 0)]
        public void Multiplicar_DoisNumeros_RetornaMultiplicacao(int numero1, int numero2, int resultadoEsperado)
        {
            var calculadora = new Calculadora();

            int resultado = calculadora.Multiplicar(numero1, numero2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(2, 1, 2)]
        [InlineData(4, -2, -2)]
        [InlineData(2, 2, 1)]
        [InlineData(1, 2, 0)]
        public void Dividir_DoisNumeros_RetornaDivisao(int numero1, int numero2, int resultadoEsperado)
        {
            var calculadora = new Calculadora();

            int resultado = calculadora.Dividir(numero1, numero2);

            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void Dividir_PorZero_JogaExcecao()
        {
            var calculadora = new Calculadora();

            void act() => calculadora.Dividir(1, 0);

            Assert.Throws<DivideByZeroException>(act);
        }

        [Fact]
        public void Historico_AposUmaOperacao_RetornaListaComUmItem()
        {
            var calculadora = new Calculadora();

            calculadora.Somar(1, 1);
            List<string> historico = calculadora.Historico();
            int resultado = historico.Count;

            Assert.Equal(1, resultado);
        }

        [Fact]
        public void Historico_AposQuatroOperacoes_RetornaListaComTresItens()
        {
            var calculadora = new Calculadora();

            calculadora.Somar(1, 1);
            calculadora.Somar(1, 1);
            calculadora.Somar(1, 1);
            calculadora.Somar(1, 1);
            List<string> historico = calculadora.Historico();
            int resultado = historico.Count;

            Assert.Equal(3, resultado);
        }

        [Fact]
        public void Historico_AposOperacao_RetornaOperacaoCorreta()
        {
            var calculadora = new Calculadora();

            calculadora.Somar(1, 2);
            List<string> historico = calculadora.Historico();
            string resultado = historico[0];

            Assert.Equal("1 + 2 = 3", resultado);
        }

        [Fact]
        public void Historico_AposQuatroOperacoes_RetornaOperacoesCorretas()
        {
            var calculadora = new Calculadora();

            calculadora.Somar(1, 2);
            calculadora.Somar(3, 4);
            calculadora.Somar(5, 6);
            calculadora.Somar(7, 8);
            List<string> historico = calculadora.Historico();
            string resultado1 = historico[0];
            string resultado2 = historico[1];
            string resultado3 = historico[2];

            Assert.Equal("3 + 4 = 7", resultado1);
            Assert.Equal("5 + 6 = 11", resultado2);
            Assert.Equal("7 + 8 = 15", resultado3);
        }
    }
}
