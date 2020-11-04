using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ProvaOBI2019_Idade.Test
{
    public class CalculadoraIdadeTests
    {
        private readonly CalculadoraIdade calculadora;

        public CalculadoraIdadeTests()
        {
            calculadora = new CalculadoraIdade();
        }

        [Theory]
        [InlineData(52, 14, 18, 20)]
        [InlineData(47, 21, 9, 21)]
        public void CalcularIdadeFilhoMaisVelho_DeveRetornarAIdadeFilhoMaisVelho(int idadeMae, int idadeFilhoA, int idadeFilhoB, int expected)
        {
            //Act
            var result = calculadora.CalcularIdadeFilhoMaisVelho(idadeMae, idadeFilhoA, idadeFilhoB);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 14, 18, 0)]
        [InlineData(150, 21, 9, 0)]
        public void CalcularIdadeFilhoMaisVelho_DeveTratarIdadeMaeInvalida(int idadeMae, int idadeFilhoA, int idadeFilhoB, int expected)
        {
            //Act
            var result = calculadora.CalcularIdadeFilhoMaisVelho(idadeMae, idadeFilhoA, idadeFilhoB);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(50, 14, 80, 0)]
        [InlineData(60, 75, 9, 0)]
        [InlineData(47, 9, 9, 0)]
        public void CalcularIdadeFilhoMaisVelho_DeveTratarIdadeFilhoInvalida(int idadeMae, int idadeFilhoA, int idadeFilhoB, int expected)
        {
            //Act
            var result = calculadora.CalcularIdadeFilhoMaisVelho(idadeMae, idadeFilhoA, idadeFilhoB);

            Assert.Equal(expected, result);
        }
    }
}
