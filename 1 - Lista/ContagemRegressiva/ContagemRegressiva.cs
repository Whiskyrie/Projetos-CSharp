using System;

namespace ContagemRegressiva;

class ContagemR 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Contagem regressiva.");
        Console.WriteLine("Digite o número que deseja contar regressivamente: ");
        
        int numero = int.Parse(Console.ReadLine() ?? "0");

        for (int i = numero; i >= 0; i--)
        {
            Console.WriteLine(i);
            System.Threading.Thread.Sleep(1000); // Pausa de 1 segundo entre cada número
        }

        Console.WriteLine("Contagem regressiva concluída!");
        Console.ReadLine(); // Aguarda o usuário pressionar uma tecla antes de fechar
    }
}