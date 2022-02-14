using System;

namespace Exercicio4_ListaPresencial.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] valores = new int[5];
            int contNegativos = 0, contPositivos = 0;
            double media = 0, media2;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Digite o valor " + i + ": ");
                valores[i] = Convert.ToInt32(Console.ReadLine());

                if (valores[i] < 0)
                {
                    contNegativos++;
                }
                else
                {
                    contPositivos++;
                }

                media = media + valores[i];
            }
            media2 = media / 5;

            Console.WriteLine("A Média Aritmética é: " + media2);
            Console.WriteLine("A quantidade de valores positivos é: " + contPositivos);
            Console.WriteLine("A quantidade de valores negativos é: " + contNegativos);

        }
    }
}
