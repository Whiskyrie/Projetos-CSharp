using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> frutas = new List<string>();
        string? entrada;

        Console.WriteLine("Digite os nomes das frutas (ou 'sair' para encerrar):");

        do
        {
            entrada = Console.ReadLine()?.Trim(); // Verifica se a entrada não é nula antes de chamar Trim()

            if (!string.IsNullOrWhiteSpace(entrada) && !int.TryParse(entrada, out _) && entrada.ToLower() != "sair")
            {
                frutas.Add(entrada);
            }
            else if (int.TryParse(entrada, out _))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um nome de fruta válido.");
            }
        } while (entrada?.ToLower() != "sair"); // Verifica se a entrada não é nula antes de chamar ToLower()

        Console.WriteLine("\nFrutas em ordem alfabética:");
        foreach (string fruta in frutas.OrderBy(f => f))
        {
            Console.WriteLine(fruta);
        }

        Console.ReadLine();
    }
}