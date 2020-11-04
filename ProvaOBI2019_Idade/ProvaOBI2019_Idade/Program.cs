using System;

namespace ProvaOBI2019_Idade
{
    class Program
    {
        public static void Main(string[] args)
        {
            CalculadoraIdade calculadora = new CalculadoraIdade();
            var resultado = calculadora.CalcularIdadeFilhoMaisVelho(0,0,0);
        } 
    }
}
