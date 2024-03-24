class Triangulo
{
    public double Base { get; set; }
    public double Altura { get; set; }

    public double CalcularArea()
    {
        return 0.5 * Base * Altura;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a base do triângulo: ");
        double base_;
        while (!double.TryParse(Console.ReadLine(), out base_))
        {
            Console.WriteLine("Entrada inválida. Digite um número decimal para a base.");
            Console.Write("Digite a base do triângulo: ");
        }

        Console.Write("Digite a altura do triângulo: ");
        double altura;
        while (!double.TryParse(Console.ReadLine(), out altura))
        {
            Console.WriteLine("Entrada inválida. Digite um número decimal para a altura.");
            Console.Write("Digite a altura do triângulo: ");
        }

        Triangulo triangulo = new()
        {
            Base = base_,
            Altura = altura
        };

        double area = triangulo.CalcularArea();
        Console.WriteLine($"A área do triângulo com base {base_} e altura {altura} é: {area}");
    }
}