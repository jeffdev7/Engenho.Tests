using System;

namespace ENGENHO.Numbers
{
    internal class Program
    {
        /// <summary>
        ///- Crie uma aplicação Console que some os números naturais múltiplos de 3 e 5 de uma sequência, seguindo as regras abaixo:
        ///- A aplicação deve solicitar um número ao usuário.
        ///- Em seguida a aplicação irá somar todos os números naturais de 0 até o número informado que sejam múltiplos de 3 ou 5.
        ///- No final, deverá ser exibida a soma desses números ao usuário.
        /// </summary>
        /// <param name="n"></param>
        /// 
        public void findMultiples(int n)
        {
            for (int i = 0; i <= n; ++i)
                if (i % 3 == 0 && i % 5 == 0)
                    Console.WriteLine(i);

        }
        static void Main(string[] args)
        {
            int somaDosNumerosNaturaisMultiplos = 0;

            Console.WriteLine("Entre com um número natural:\n");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Você digitou {number}\n");

            Program p = new Program();
            p.findMultiples(number);

            for (int i = 0; i <= number; ++i)
                if (i % 3 == 0 && i % 5 == 0)
                    somaDosNumerosNaturaisMultiplos += i;

            Console.WriteLine($"\nA soma dos números naturais múltiplos de 3 e 5 é: {somaDosNumerosNaturaisMultiplos}"); ;
        }
    }
}
