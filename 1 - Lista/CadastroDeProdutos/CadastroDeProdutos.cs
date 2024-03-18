using System;
using System.Collections.Generic;
using System.IO;

struct Produto
{
    public string Nome;
    public double Preco;
}

class Program
{
    static string arquivoProdutos = "produtos.txt";

    static void Main(string[] args)
    {
        List<Produto> produtos = CarregarProdutos();

while (true)
        {
            Console.WriteLine("1. Cadastrar novo produto");
            Console.WriteLine("2. Listar produtos cadastrados");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();
                    Console.Write("Digite o preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());

                    // Criando um novo produto e adicionando à lista
                    Produto novoProduto = new() { Nome = nome, Preco = preco };
                    produtos.Add(novoProduto);
                    Console.WriteLine("Produto cadastrado com sucesso!");
                    break;

                case 2:
                    Console.WriteLine("Produtos cadastrados:");
                    foreach (Produto produto in produtos)
                    {
                        Console.WriteLine($"{produto.Nome} - R${produto.Preco:0.00}");
                    }
                    break;

                case 3:
                    Console.WriteLine("Encerrando o programa...");
                    return;

                default:
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    break;
            }

        SalvarProdutos(produtos);
    }

    static List<Produto> CarregarProdutos()
    {
        List<Produto> produtos = new List<Produto>();

        if (File.Exists(arquivoProdutos))
        {
            string[] linhas = File.ReadAllLines(arquivoProdutos);
            foreach (string linha in linhas)
            {
                string[] dados = linha.Split(',');
                Produto produto = new Produto
                {
                    Nome = dados[0],
                    Preco = double.Parse(dados[1])
                };
                produtos.Add(produto);
            }
        }

        return produtos;
    }

    static void SalvarProdutos(List<Produto> produtos)
    {
        string[] linhas = new string[produtos.Count];
        for (int i = 0; i < produtos.Count; i++)
        {
            linhas[i] = $"{produtos[i].Nome},{produtos[i].Preco}";
        }
        File.WriteAllLines(arquivoProdutos, linhas);
    }
}
}