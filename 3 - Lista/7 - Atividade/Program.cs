class Retangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double CalcularArea()
    {
        return Base * Altura;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a base do Retângulo: ");
        double base_;
        while (!double.TryParse(Console.ReadLine(), out base_))
        {
            Console.WriteLine("Entrada inválida. Digite um número decimal para a base.");
            Console.Write("Digite a base do Retângulo: ");
        }

        Console.Write("Digite a altura do Retângulo: ");
        double altura;
        while (!double.TryParse(Console.ReadLine(), out altura))
        {
            Console.WriteLine("Entrada inválida. Digite um número decimal para a altura.");
            Console.Write("Digite a altura do Retângulo: ");
        }

        Retangulo retangulo = new()
        {
            Base = base_,
            Altura = altura
        };

        double area = retangulo.CalcularArea();
        Console.WriteLine($"A área do Retângulo com base {base_} e altura {altura} é: {area}");
    }
}