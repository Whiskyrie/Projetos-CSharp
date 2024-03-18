using System;

class Program
{
    static void Main(string[] args)
    {
        // Gera um número aleatório entre 1 e 100
        Random random = new();
        int numeroAleatorio = random.Next(1, 101);

        int palpite;
        int tentativas = 0;

        Console.WriteLine("Bem-vindo ao Jogo de Adivinhação!");
        Console.WriteLine("Estou pensando em um número entre 1 e 100. Tente adivinhar qual é.");

        do
        {
            Console.Write("Digite seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;

            if (palpite < numeroAleatorio)
            {
                Console.WriteLine("Seu palpite é muito baixo. Tente um número maior.");
            }
            else if (palpite > numeroAleatorio)
            {
                Console.WriteLine("Seu palpite é muito alto. Tente um número menor.");
            }
            else
            {
                Console.WriteLine($"Parabéns! Você acertou em {tentativas} tentativas.");
            }
        } while (palpite != numeroAleatorio);

        Console.WriteLine("Pressione qualquer tecla para sair...");
        Console.ReadKey();
    }
}