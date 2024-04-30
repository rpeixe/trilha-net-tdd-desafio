using System;
using Xunit;
using TDD;

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
    }
}
