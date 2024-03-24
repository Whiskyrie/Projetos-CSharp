class Calculadora
{
    public static double Somar(double numero1, double numero2)
    {
        return numero1 + numero2;
    }

    public static double Subtrair(double numero1, double numero2)
    {
        return numero1 - numero2;
    }

    public static double Multiplicar(double numero1, double numero2)
    {
        return numero1 * numero2;
    }

    public static double Dividir(double numero1, double numero2)
    {
        if (numero2 == 0)
        {
            throw new DivideByZeroException("Não é possível dividir por zero.");
        }
        return numero1 / numero2;
    }
}

class Resultado
{
    static void Main(string[] args)
    {
        Calculadora calculadora = new();

        double numero1, numero2;
        double resultado;

        Console.Write("Digite o primeiro número: ");
        double.TryParse(Console.ReadLine(), out numero1);

        Console.Write("Digite o segundo número: ");
        double.TryParse(Console.ReadLine(), out numero2);

        resultado = Calculadora.Somar(numero1, numero2);
        Console.WriteLine($"Soma: {numero1} + {numero2} = {resultado}");

        resultado = Calculadora.Subtrair(numero1, numero2);
        Console.WriteLine($"Subtração: {numero1} - {numero2} = {resultado}");

        resultado = Calculadora.Multiplicar(numero1, numero2);
        Console.WriteLine($"Multiplicação: {numero1} x {numero2} = {resultado}");

        resultado = Calculadora.Dividir(numero1, numero2);
        Console.WriteLine($"Divisão: {numero1} / {numero2} = {resultado}");
    }
}