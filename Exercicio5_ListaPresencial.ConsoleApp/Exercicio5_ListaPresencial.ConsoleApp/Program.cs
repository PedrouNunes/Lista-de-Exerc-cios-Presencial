using System;

namespace Exercicio5_ListaPresencial.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numero = new int[3];
            String[] nome = new String[3];
            int maior = 0, saber = 0;

            for (int i = 1; i <= 2; i++)
            {
                Console.Write("Digite o nome do participante " + i + ": ");
                nome[i] = Convert.ToString(Console.ReadLine());
            }
            
                for (int i = 1; i < 4; i++)
                {
                    for (int j = 1; j <= 2; j++)
                    {
                    do
                    {
                        Console.Write("Digite o numero do participante " + j + ": ");
                        numero[j] = Convert.ToInt32(Console.ReadLine());
                    } while (numero[j] < 0 || numero[j] > 6);

                    if (numero[j] > maior)
                        {
                            maior = numero[j];
                            saber = j;
                        }
                }
                Console.WriteLine(i + "a Rodada:");
                Console.WriteLine(nome[1] + ": " + numero[1]);
                Console.WriteLine(nome[2] + ": " + numero[2]);

                if (numero[1] == numero[2])
                {
                    Console.WriteLine("Houve um empate defintivo, tentem novamente!");
                }
                else
                {
                    Console.WriteLine("O jogador " + nome[saber] + " jogou " + maior + " e venceu a " + i + "a rodada!");
                }
            }               
        }
    }
}
