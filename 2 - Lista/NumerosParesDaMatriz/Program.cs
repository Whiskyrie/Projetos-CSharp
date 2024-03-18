using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Write("Digite o número de linhas da matriz: ");
            int linhas;
            while (!int.TryParse(Console.ReadLine(), out linhas) || linhas <= 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro válido maior que zero.");
                Console.Write("Digite o número de linhas da matriz: ");
            }

            Console.Write("Digite o número de colunas da matriz: ");
            int colunas;
            while (!int.TryParse(Console.ReadLine(), out colunas) || colunas <= 0)
            {
                Console.WriteLine("Por favor, digite um número inteiro válido maior que zero.");
                Console.Write("Digite o número de colunas da matriz: ");
            }

            int[,] matriz = new int[linhas, colunas];

            Console.WriteLine("Digite os valores da matriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    int valor;
                    Console.Write($"Elemento [{i}][{j}]: ");
                    while (!int.TryParse(Console.ReadLine(), out valor))
                    {
                        Console.WriteLine("Por favor, digite um número inteiro válido.");
                        Console.Write($"Elemento [{i}][{j}]: ");
                    }
                    matriz[i, j] = valor;
                }
            }

            Console.WriteLine("\nMatriz:");
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Conta o número de números pares na matriz
            int pares = 0;
            for (int i = 0; i < linhas; i++)
            {
                for (int j = 0; j < colunas; j++)
                {
                    if (matriz[i, j] % 2 == 0)
                    {
                        pares++;
                    }
                }
            }

            // Exibe o número de números pares
            Console.WriteLine($"\nNúmero de números pares na matriz: {pares}");

        }

    }
}
