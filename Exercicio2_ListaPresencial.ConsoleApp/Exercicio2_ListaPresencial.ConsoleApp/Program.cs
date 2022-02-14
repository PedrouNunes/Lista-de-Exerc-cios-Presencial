using System;

namespace Exercicio2_ListaPresencial.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a largura do retângulo: ");
            int largura = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a altura do retângulo: ");
            int altura = Convert.ToInt32(Console.ReadLine());

            String imparesOuPares = "";
            for (int i = 0; i < altura; i++)
            {
                for (int j = 0; j < largura; j++)
                {
                    if (i % 2 == 0)
                    {            
                     imparesOuPares = imparesOuPares + "A";
                    }
                    else
                    {
                        imparesOuPares = imparesOuPares + "B";
                    }
                }
                imparesOuPares += "\n";
            }
            Console.WriteLine(imparesOuPares);
        }
    }
}
