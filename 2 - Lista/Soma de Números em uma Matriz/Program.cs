using System;

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

        int soma = 0;

        // Calcula a soma de todos os números na matriz
        foreach (int numero in numeros)
        {
            soma += numero;
        }

        Console.WriteLine($"\nA soma de todos os números na matriz é: {soma}");
        Console.ReadLine();
    }
}