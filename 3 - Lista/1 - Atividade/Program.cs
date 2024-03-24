class Pessoa(string nome, int idade, double altura)
{
    // Propriedades
    public string Nome { get; set; } = nome;
    public int Idade { get; set; } = idade;
    public double Altura { get; set; } = altura;

    // Método para imprimir os dados
    public void ImprimirDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
        Console.WriteLine($"Altura: {Altura}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Criando uma instância da classe Pessoa e imprimindo os dados
        Pessoa pessoa1 = new("João", 30, 1.75);
        pessoa1.ImprimirDados();
    }
}