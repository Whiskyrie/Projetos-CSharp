using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> cores = [];
        string? entrada;
        int contadorCoresPrimarias = 0;

        Console.WriteLine("Digite os nomes das cores (ou 'sair' para encerrar):");

        do
        {
            entrada = Console.ReadLine()?.Trim(); // Verifica se a entrada não é nula antes de chamar Trim()

            if (!string.IsNullOrWhiteSpace(entrada) && !int.TryParse(entrada, out _) && !entrada.Equals("sair", StringComparison.CurrentCultureIgnoreCase))
            {
                cores.Add(entrada.ToLower()); // Adiciona a cor em letras minúsculas
            }
            else if (int.TryParse(entrada, out _))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um nome de cor válido.");
            }
        } while (entrada?.ToLower() != "sair"); // Verifica se a entrada não é nula antes de chamar ToLower()

        Console.WriteLine("\nCores inseridas:");
        foreach (string cor in cores)
        {
            Console.WriteLine(cor);

            // Verifica se a cor é uma cor primária
            if (cor == "vermelho" || cor == "azul" || cor == "amarelo")
            {
                contadorCoresPrimarias++;
            }
        }

        Console.WriteLine($"\nQuantidade de cores primárias (vermelho, azul e amarelo): {contadorCoresPrimarias}");

        Console.ReadLine();
    }
}