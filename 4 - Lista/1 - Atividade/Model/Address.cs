namespace Model;

public class Endereco
{
    public Endereco() { }

    public static Endereco? EnderecoResidencial { get; set; }
    public string? Logradouro { get; set; }
    public string? Cidade { get; set; }
    public string? Estado { get; set; }
    public string? Pais { get; set; }
    public string? CEP { get; set; }

    public static void AtualizarEndereco()
    {
        Console.Write("Digite o novo logradouro: ");
        string? novoLogradouro = Console.ReadLine();

        Console.Write("Digite a nova cidade: ");
        string? novaCidade = Console.ReadLine();

        Console.Write("Digite o novo estado: ");
        string? novoEstado = Console.ReadLine();

        Console.Write("Digite o novo país: ");
        string? novoPais = Console.ReadLine();

        Console.Write("Digite o novo CEP: ");
        string? novoCEP = Console.ReadLine();

        EnderecoResidencial = new Endereco
        {
            Logradouro = novoLogradouro,
            Cidade = novaCidade,
            Estado = novoEstado,
            Pais = novoPais,
            CEP = novoCEP
        };
    }
}

