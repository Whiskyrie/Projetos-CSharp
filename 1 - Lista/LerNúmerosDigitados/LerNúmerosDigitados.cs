using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> positivosNumeros = new List<int>();

        int numero;
        Console.WriteLine("Digite números (digite um número negativo para parar):");

        do
        {
            numero = int.Parse(Console.ReadLine());

            if (numero >= 0)
            {
                positivosNumeros.Add(numero);
            }
        } while (numero >= 0);

        Console.WriteLine("\nNúmeros positivos digitados:");
        foreach (int n in positivosNumeros)
        {
            Console.Write(n + " ");
        }

        Console.ReadLine();
    }
}