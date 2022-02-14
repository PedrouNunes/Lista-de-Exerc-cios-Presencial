using System;

namespace Exercicio3_ListaPresencial.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a hora: ");
            int horaAtual = Convert.ToInt32(Console.ReadLine());

            if (horaAtual > 5 && horaAtual < 12)
            {
                Console.WriteLine("Bom dia.");
            }
            else
            {
                if (horaAtual >= 12 && horaAtual < 18)
                {
                    Console.WriteLine("Boa tarde.");
                }
                else
                {                 
                        Console.WriteLine("Boa noite.");                
                }
            }
        }
    }
}
