class ConversorDeMoedas
{
    public static double ConverteDolarParaReal(double valorDolar, double taxaCambio)
    {
        return valorDolar * taxaCambio;
    }

    public static double ConverteRealParaDolar(double valorReal, double taxaCambio)
    {
        return valorReal / taxaCambio;
    }

    public static double ConverteEuroParaReal(double valorEuro, double taxaCambio)
    {
        return valorEuro * taxaCambio;
    }

    public static double ConverteRealParaEuro(double valorReal, double taxaCambio)
    {
        return valorReal / taxaCambio;
    }
}

class Program
{
    static void Main(string[] args)
    {
        ConversorDeMoedas conversor = new();

        double taxaCambioDolar = 5.0; // 1 USD = 5.0 BRL
        double taxaCambioEuro = 5.5; // 1 EUR = 5.5 BRL

        Console.WriteLine("Conversões:");
        Console.WriteLine("1. Dólar para Real");
        Console.WriteLine("2. Real para Dólar");
        Console.WriteLine("3. Euro para Real");
        Console.WriteLine("4. Real para Euro");
        Console.Write("Digite o número da opção desejada: ");

        int opcao;
        while (!int.TryParse(Console.ReadLine(), out opcao) || opcao < 1 || opcao > 4)
        {
            Console.WriteLine("Opção inválida. Digite um número entre 1 e 4.");
            Console.Write("Digite o número da opção desejada: ");
        }

        double valor;
        Console.Write("Digite o valor a ser convertido: ");
        while (!double.TryParse(Console.ReadLine(), out valor))
        {
            Console.WriteLine("Entrada inválida. Digite um valor válido.");
            Console.Write("Digite o valor a ser convertido: ");
        }

        double valorConvertido;
        switch (opcao)
        {
            case 1:
                valorConvertido = ConversorDeMoedas.ConverteDolarParaReal(valor, taxaCambioDolar);
                Console.WriteLine($"{valor} dólares equivalem a R$ {valorConvertido}");
                break;
            case 2:
                valorConvertido = ConversorDeMoedas.ConverteRealParaDolar(valor, taxaCambioDolar);
                Console.WriteLine($"R$ {valor} equivalem a {valorConvertido} dólares");
                break;
            case 3:
                valorConvertido = ConversorDeMoedas.ConverteEuroParaReal(valor, taxaCambioEuro);
                Console.WriteLine($"{valor} euros equivalem a R$ {valorConvertido}");
                break;
            case 4:
                valorConvertido = ConversorDeMoedas.ConverteRealParaEuro(valor, taxaCambioEuro);
                Console.WriteLine($"R$ {valor} equivalem a {valorConvertido} euros");
                break;
        }
    }
}