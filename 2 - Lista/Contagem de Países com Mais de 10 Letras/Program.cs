using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> paises = new List<string>();
        List<string> paisesGrandes = new List<string>(); // Lista para armazenar países com mais de 10 letras
        string? entrada;
        int contadorPaisesGrandes = 0;

        Console.WriteLine("Digite os nomes dos países (ou 'sair' para encerrar):");

        do
        {
            entrada = Console.ReadLine()?.Trim(); // Verifica se a entrada não é nula antes de chamar Trim()

            if (!string.IsNullOrWhiteSpace(entrada) && !int.TryParse(entrada, out _) && !entrada.Equals("sair", StringComparison.CurrentCultureIgnoreCase))
            {
                paises.Add(entrada);
            }
            else if (int.TryParse(entrada, out _))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um nome de país válido.");
            }
        } while (entrada?.ToLower() != "sair"); // Verifica se a entrada não é nula antes de chamar ToLower()

        Console.WriteLine("\nPaíses inseridos:");
        foreach (string pais in paises)
        {
            Console.WriteLine(pais);

            // Verifica se o país tem mais de 10 letras
            if (pais.Length > 10)
            {
                contadorPaisesGrandes++;
                paisesGrandes.Add(pais); // Adiciona o país à lista de países grandes
            }
        }

        Console.WriteLine($"\nQuantidade de países com mais de 10 letras: {contadorPaisesGrandes}");

        if (contadorPaisesGrandes > 0)
        {
            Console.WriteLine("\nPaíses com mais de 10 letras:");
            foreach (string paisGrande in paisesGrandes)
            {
                Console.WriteLine(paisGrande);
            }
        }

        Console.ReadLine();
    }
}