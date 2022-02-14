using System;

namespace Exercicio1_ListaPresencial.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a largura do retângulo: ");
            int largura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            int altura = Convert.ToInt32(Console.ReadLine());

            String asterisco = "";
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    asterisco = asterisco + "*";
                }
                asterisco += "\n";
            }
            Console.WriteLine(asterisco);
        }
    }     
}
    

