using System;
using Model;

namespace CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Conversor de Moedas!");

            // Solicitar informações da moeda de compra
            string? simboloCompra, nomeCompra, paisCompra;
            do
            {
                Console.Write("Digite o símbolo da moeda de compra: ");
            } while (!ObterEntradaValida(out simboloCompra));

            do
            {
                Console.Write("Digite o nome da moeda de compra: ");
            } while (!ObterEntradaValida(out nomeCompra));

            do
            {
                Console.Write("Digite o país da moeda de compra: ");
            } while (!ObterEntradaValida(out paisCompra));

            // Solicitar informações da moeda de venda
            string? simboloVenda, nomeVenda, paisVenda;
            do
            {
                Console.Write("Digite o símbolo da moeda de venda: ");
            } while (!ObterEntradaValida(out simboloVenda));

            do
            {
                Console.Write("Digite o nome da moeda de venda: ");
            } while (!ObterEntradaValida(out nomeVenda));

            do
            {
                Console.Write("Digite o país da moeda de venda: ");
            } while (!ObterEntradaValida(out paisVenda));

            // Criar instâncias de Moeda
            Moeda moedaCompra, moedaVenda;
            try
            {
                moedaCompra = new Moeda(simboloCompra, nomeCompra, paisCompra);
                moedaVenda = new Moeda(simboloVenda, nomeVenda, paisVenda);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Erro ao criar instâncias de Moeda: {ex.Message}");
                Console.ReadLine();
                return;
            }

            // Solicitar taxas de compra e venda
            double taxaCompra, taxaVenda;
            do
            {
                Console.Write("Digite a taxa de compra: ");
            } while (!double.TryParse(Console.ReadLine(), out taxaCompra));

            do
            {
                Console.Write("Digite a taxa de venda: ");
            } while (!double.TryParse(Console.ReadLine(), out taxaVenda));

            // Criar instância de Conversor
            Conversor conversor = new Conversor(moedaCompra, moedaVenda, taxaCompra, taxaVenda);

            // Solicitar valor para conversão
            double valor;
            do
            {
                Console.Write("Digite o valor a ser convertido: ");
            } while (!double.TryParse(Console.ReadLine(), out valor));

            // Converter valor
            double valorConvertidoCompra = conversor.CalcularValorCompra(valor);
            double valorConvertidoVenda = conversor.CalcularValorVenda(valor);

            // Exibir resultados
            Console.WriteLine();
            Console.WriteLine($"Valor de compra ({moedaCompra.Simbolo} -> {moedaVenda.Simbolo}): {valorConvertidoCompra} {moedaVenda.Nome}");
            Console.WriteLine($"Valor de venda ({moedaVenda.Simbolo} -> {moedaCompra.Simbolo}): {valorConvertidoVenda} {moedaCompra.Nome}");

            Console.ReadLine();
        }

        static bool ObterEntradaValida(out string? entrada)
        {
            entrada = Console.ReadLine()?.Trim();
            return !string.IsNullOrEmpty(entrada);
        }
    }
}