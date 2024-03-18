using System;

class Program {
    static void Main(string[] args) {
        Console.WriteLine("Informe o número que deseja saber o fatorial:");
        int num = int.Parse(Console.ReadLine() ?? "0");
        int result = Factorial(num);
        Console.WriteLine($"Factorial de {num} é {result}");
        Console.ReadKey();
    }

    static int Factorial(int n) {
        if (n == 0) {
            return 1;
        } else {
            return n * Factorial(n - 1);
        }
    }
}