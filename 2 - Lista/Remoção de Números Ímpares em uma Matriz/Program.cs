using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o tamanho da matriz: ");
        int tamanho;

        // Garante que o usuário insira um valor inteiro válido para o tamanho da matriz
        while (!int.TryParse(Console.ReadLine(), out tamanho) || tamanho <= 0)
        {
            Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro positivo.");
            Console.Write("Digite o tamanho da matriz: ");
        }

        int[] numeros = new int[tamanho];

        // Solicita ao usuário para inserir valores na matriz
        for (int i = 0; i < tamanho; i++)
        {
            Console.Write($"Digite o número para a posição {i}: ");
            string? entrada = Console.ReadLine()?.Trim(); // Verifica se a entrada não é nula antes de chamar Trim()

            // Garante que o usuário insira um valor inteiro válido
            while (string.IsNullOrWhiteSpace(entrada) || !int.TryParse(entrada, out numeros[i]))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
                Console.Write($"Digite o número para a posição {i}: ");
                entrada = Console.ReadLine()?.Trim(); // Verifica se a entrada não é nula antes de chamar Trim()
            }
        }

        List<int> numerosParesTemporario = new List<int>();

        // Remove todos os números ímpares da matriz
        foreach (int numero in numeros)
        {
            if (numero % 2 == 0)
            {
                numerosParesTemporario.Add(numero);
            }
        }

        // Atualiza a matriz com os números pares
        numeros = numerosParesTemporario.ToArray();

        Console.WriteLine("\nMatriz após a remoção dos números ímpares:");
        foreach (int numero in numeros)
        {
            Console.Write(numero + " ");
        }

        Console.ReadLine();
    }
}