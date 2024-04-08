
using Model;

namespace SistemaDoBanco
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
                Console.WriteLine("4. Atualizar Endereço");
                Console.WriteLine("5. Mostrar Saldo");
                Console.WriteLine("6. Mostrar Dados dos Clientes");
                Console.WriteLine("0. Sair");
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
                        Console.WriteLine("\n### Atualizar Endereço ###");
                        AtualizarEndereco(clientes, contas);
                        Console.WriteLine("Endereço atualizado com sucesso!");
                        break;
                    case "5":
                        Console.WriteLine("\n### Mostrar Saldo ###");
                        MostrarSaldo(contas);
                        break;
                    case "6":
                        Console.WriteLine("\n### Mostrar Dados dos Clientes ###");
                        MostrarDadosClientes(clientes);
                        break;
                    case "0":
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

        static void MostrarSaldo(List<BankAccount> contas)
        {
            Console.Write("Número da Conta: ");
            string? numeroConta = Console.ReadLine();

            BankAccount? conta = contas.Find(c => c.NumeroConta == numeroConta);
            if (conta == null)
            {
                Console.WriteLine("Conta não encontrada.");
                return;
            }

            Console.WriteLine($"Saldo da conta {conta.NumeroConta}: {conta.Saldo:C}");
        }
        static void AtualizarEndereco(List<Cliente> clientes, List<BankAccount> contas)
        {
            Console.Write("Número da Conta: ");
            string? numeroConta = Console.ReadLine();

            BankAccount? conta = contas.Find(c => c.NumeroConta == numeroConta);
            if (conta == null)
            {
                Console.WriteLine("Conta não encontrada.");
                return;
            }

            Cliente? cliente = clientes.Find(c => c.Email == conta.Titular.Email);
            if (cliente == null)
            {
                Console.WriteLine("Cliente não encontrado.");
                return;
            }

            Endereco.AtualizarEndereco();
            cliente.AtualizarEnderecoResidencial(Endereco.EnderecoResidencial);
            Console.WriteLine("Endereço atualizado com sucesso!");
        }
        static void MostrarDadosClientes(List<Cliente> clientes)
        {
            if (clientes.Count == 0)
            {
                Console.WriteLine("Nenhum cliente cadastrado.");
                return;
            }

            Console.WriteLine("Dados dos Clientes Cadastrados:");
            foreach (Cliente cliente in clientes)
            {
                Console.WriteLine($"Nome: {cliente.Nome}");
                Console.WriteLine($"Endereço: {cliente.EnderecoResidencial.Logradouro}, {cliente.EnderecoResidencial.Cidade}, {cliente.EnderecoResidencial.Estado}, {cliente.EnderecoResidencial.Pais}, {cliente.EnderecoResidencial.CEP}");
                Console.WriteLine($"Email: {cliente.Email}");
                Console.WriteLine();
            }
        }
    }
}