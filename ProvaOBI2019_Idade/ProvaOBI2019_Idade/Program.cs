using System;

namespace ProvaOBI2019_Idade
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Informe a idade de dona Mônica: ");
                var idadeMae = Convert.ToInt32(Console.ReadLine()); //Idade da dona Mônica                
                Console.Write("Digite a idade do primeiro filho: ");
                var idadeFilhoA = Convert.ToInt32(Console.ReadLine()); //Idade de um dos filhos
                Console.Write("Digite a idade do segundo filho: ");
                var idadeFilhoB = Convert.ToInt32(Console.ReadLine()); //Idade de um dos filhos                                  
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor digitado não é um número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("O valor digitado excede os limites suportados.");
            }

            CalculadoraIdade calculadora = new CalculadoraIdade();
            var resultado = calculadora.CalcularIdadeFilhoMaisVelho(0,0,0);
        } 
    }
}
