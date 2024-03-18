using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> frutas = [];
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

        Console.WriteLine("\nFrutas inseridas:");
        foreach (string fruta in frutas)
        {
            Console.WriteLine(fruta);
        }

        if (frutas.Count > 0)
        {
            Console.WriteLine($"\nPrimeira fruta na matriz: {frutas[0]}");
            Console.WriteLine($"Última fruta na matriz: {frutas[frutas.Count - 1]}");
        }
        else
        {
            Console.WriteLine("\nNenhuma fruta foi inserida.");
        }

        Console.ReadLine();
    }
}