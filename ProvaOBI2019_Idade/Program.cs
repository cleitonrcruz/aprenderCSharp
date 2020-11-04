using System;

namespace ProvaOBI2019_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Digite o primeiro número: ");
                var soma = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Digite o numero a ser dividido: ");
                var quantidade = Convert.ToDecimal(Console.ReadLine());
                var media = soma / quantidade;
                Console.WriteLine("Média calculada: " + media);
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor digitado não é um número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("O valor digitado excede os limites suportados.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
        }
    }
}
