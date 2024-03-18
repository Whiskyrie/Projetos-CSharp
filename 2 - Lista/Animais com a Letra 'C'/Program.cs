using System;

partial class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite o número de animais: ");

        // Verifica se o usuário inseriu um valor inteiro válido
        if (!int.TryParse(Console.ReadLine(), out int numAnimais) || numAnimais <= 0)
        {
            Console.WriteLine("Entrada inválida. O número de animais deve ser um inteiro positivo.");
            return;
        }

        string[] animais = new string[numAnimais];

        // Pede ao usuário para inserir os nomes dos animais
        for (int i = 0; i < numAnimais; i++)
        {
            Console.Write($"Digite o nome do animal #{i + 1}: ");
            string nome;

            try
            {
                nome = Console.ReadLine() ?? string.Empty;

                // Verifica se o nome do animal não está vazio
                if (string.IsNullOrWhiteSpace(nome))
                {
                    Console.WriteLine("O nome do animal não pode estar vazio. Tente novamente.");
                    i--; // Decrementa i para solicitar o mesmo índice novamente
                    continue;
                }

                // Verifica se o nome do animal contém apenas letras
                // Verifica se o nome do animal contém apenas letras e espaços
                if (!MyRegex().IsMatch(nome))
                {
                    Console.WriteLine("O nome do animal deve conter apenas letras e espaços. Tente novamente.");
                    i--; // Decrementa i para solicitar o mesmo índice novamente
                    continue;
                }

                animais[i] = nome;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu um erro: {ex.Message}");
                i--; // Decrementa i para solicitar o mesmo índice novamente
            }
        }

        Console.WriteLine("\nAnimais inseridos:");
        foreach (string animal in animais)
        {
            Console.WriteLine(animal);
        }

        int contarComC = 0;
        foreach (string animal in animais)
        {
            if (animal.StartsWith("C", StringComparison.OrdinalIgnoreCase))
            {
                contarComC++;
            }
        }

        Console.WriteLine($"\n{contarComC} animal(is) começa(m) com a letra 'C'.");
    }

    [System.Text.RegularExpressions.GeneratedRegex("^[a-zA-Z ]+$")]
    private static partial System.Text.RegularExpressions.Regex MyRegex();
}