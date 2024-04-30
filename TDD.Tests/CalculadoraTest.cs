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
    }
}
