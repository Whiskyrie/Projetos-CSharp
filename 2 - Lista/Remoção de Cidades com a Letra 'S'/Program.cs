using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<string> cidades = [];
        string? entrada;

        Console.WriteLine("Digite os nomes das cidades (ou 'sair' para encerrar):");

        do
        {
            entrada = Console.ReadLine()?.Trim(); // Verifica se a entrada não é nula antes de chamar Trim()

            if (!string.IsNullOrWhiteSpace(entrada) && !int.TryParse(entrada, out _) && entrada.ToLower() != "sair")
            {
                cidades.Add(entrada);
            }
            else if (int.TryParse(entrada, out _))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um nome de cidade válido.");
            }
        } while (entrada?.ToLower() != "sair"); // Verifica se a entrada não é nula antes de chamar ToLower()

        // Remove todas as cidades que começam com a letra "S"
        cidades.RemoveAll(cidade => cidade.StartsWith("S", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("\nCidades após a remoção das cidades que começam com 'S':");
        foreach (string cidade in cidades)
        {
            Console.WriteLine(cidade);
        }

        Console.ReadLine();
    }
}