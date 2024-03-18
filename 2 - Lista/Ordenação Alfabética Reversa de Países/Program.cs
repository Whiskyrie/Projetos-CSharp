using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> paises = new List<string>();
        string? entrada;

        Console.WriteLine("Digite os nomes dos países (ou 'sair' para encerrar):");

        do
        {
            entrada = Console.ReadLine()?.Trim(); // Verifica se a entrada não é nula antes de chamar Trim()

            if (!string.IsNullOrWhiteSpace(entrada) && !int.TryParse(entrada, out _) && entrada.ToLower() != "sair")
            {
                paises.Add(entrada);
            }
            else if (int.TryParse(entrada, out _))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um nome de país válido.");
            }
        } while (entrada?.ToLower() != "sair"); // Verifica se a entrada não é nula antes de chamar ToLower()

        Console.WriteLine("\nPaíses em ordem alfabética reversa:");
        foreach (string pais in paises.OrderByDescending(p => p))
        {
            Console.WriteLine(pais);
        }

        Console.ReadLine();
    }
}