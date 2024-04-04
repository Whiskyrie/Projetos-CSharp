namespace Model;

class Moeda
{
    // Preço
    // País
    // Nome da Moeda
    // Símbolo
    public string Simbolo { get; init; }
    public string Nome { get; init; }
    public string Pais { get; init; }

    public Moeda(string simbolo, string nome, string pais)
    {
        Simbolo = simbolo;
        Nome = nome;
        Pais = pais;

        if (string.IsNullOrEmpty(Simbolo) || string.IsNullOrEmpty(Nome) || string.IsNullOrEmpty(Pais))
        {
            throw new ArgumentException("Os campos não podem ser nulos ou vazios");
        }
    }

    public override string ToString()
    {
        return $"{Simbolo} ({Nome} - {Pais})";
    }
}