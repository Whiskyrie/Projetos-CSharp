
using System;
namespace CalculoMedia;

class CalculoM {
    static void Main (string[] args) {
        Console.WriteLine("Calculo de Média do aluno");
        Console.Write("Digite a quantidade de disciplina: ");

        int quantidadeDeDisciplina = int.Parse(Console.ReadLine()??"0");

        if (quantidadeDeDisciplina == 0 ) return;

        double somaDeNotas = 0;

        for (int i = 0; i < quantidadeDeDisciplina; i++) {
                Console.Write($"Digite a nota da discplina {i + 1}:");
                double nota = double.Parse(Console.ReadLine() ?? "0.0");

                somaDeNotas += nota; 
        }

        double media = somaDeNotas / quantidadeDeDisciplina;
        Console.WriteLine($"Media: {media}.");
        Console.ReadKey();
    }
}