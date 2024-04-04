using Model; // Importando o namespace onde as classes BankAccount e BankOperations estão definidas

namespace Cadastro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Cliente> clientes = []; // Lista de clientes
            List<BankAccount> contas = []; // Lista de contas bancárias

            while (true) // Loop infinito para o menu
            {
                Console.WriteLine("### Menu ###");
                Console.WriteLine("1. Criar Conta");
                Console.WriteLine("2. Depositar");
                Console.WriteLine("3. Sacar");
                Console.WriteLine("4. Sair");
                Console.Write("Escolha uma opção: ");

                string? escolha = Console.ReadLine();

                if (string.IsNullOrEmpty(escolha))
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                    continue;
                }

                switch (escolha)
                {
                    case "1":
                        Console.WriteLine("\n### Criar Conta ###");
                        BankOperations.CriarConta(clientes, contas);
                        break;
                    case "2":
                        Console.WriteLine("\n### Depositar ###");
                        BankOperations.Depositar(contas);
                        break;
                    case "3":
                        Console.WriteLine("\n### Sacar ###");
                        BankOperations.Sacar(contas);
                        break;
                    case "4":
                        Console.WriteLine("Saindo do programa...");
                        return; // Encerra o programa
                    default:
                        Console.WriteLine("Opção inválida. Tente novamente.");
                        break;
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear(); // Limpa a tela para o próximo menu
            }
        }
    }
}
