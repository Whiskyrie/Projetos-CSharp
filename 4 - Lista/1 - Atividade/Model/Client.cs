namespace Model;

public class Cliente(string nome, Endereco endereco, string email)
{
    public string Nome { get; private set; } = nome;
    public Endereco EnderecoResidencial { get; private set; } = endereco;
    public string Email { get; private set; } = email;

    public void AtualizarEndereco(Endereco novoEndereco)
    {
        EnderecoResidencial = novoEndereco;
    }
}
