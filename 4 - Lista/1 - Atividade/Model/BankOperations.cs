namespace Model
{
    public static class BankOperations
    {
        public static void CriarConta(List<Cliente> clientes, List<BankAccount> contas)
        {
            Console.Write("Nome do cliente: ");
            string? nome = Console.ReadLine();

            if (string.IsNullOrEmpty(nome))
            {
                Console.WriteLine("Nome inválido. A criação da conta foi cancelada.");
                return;
            }

            Console.Write("Endereço: ");
            string? endereco = Console.ReadLine();

            if (string.IsNullOrEmpty(endereco))
            {
                Console.WriteLine("Endereço inválido. A criação da conta foi cancelada.");
                return;
            }

            Console.Write("Cidade: "); // Added prompt for city
            string? cidade = Console.ReadLine();

            if (string.IsNullOrEmpty(cidade))
            {
                Console.WriteLine("Cidade inválida. A criação da conta foi cancelada.");
                return;
            }
            Console.Write("CEP: "); // Added prompt for city
            string? cep = Console.ReadLine();

            if (string.IsNullOrEmpty(cep))
            {
                Console.WriteLine("CEP inválida. A criação da conta foi cancelada.");
                return;
            }
            Console.Write("Estado: "); // Added prompt for city
            string? estado = Console.ReadLine();

            if (string.IsNullOrEmpty(estado))
            {
                Console.WriteLine("Estado inválida. A criação da conta foi cancelada.");
                return;
            }
            Console.Write("País: "); // Added prompt for city
            string? pais = Console.ReadLine();

            if (string.IsNullOrEmpty(pais))
            {
                Console.WriteLine("Estado inválida. A criação da conta foi cancelada.");
                return;
            }

            Console.Write("Email: ");
            string? email = Console.ReadLine();

            if (string.IsNullOrEmpty(email))
            {
                Console.WriteLine("Email inválido. A criação da conta foi cancelada.");
                return;
            }

            Endereco enderecoObj = new() { Logradouro = endereco, Cidade = cidade, CEP = cep, Estado = estado, Pais = pais }; // Set Cidade
            Cliente cliente = new(nome, enderecoObj, email);
            clientes.Add(cliente);

            Console.Write("Número da Conta: ");
            string? numeroConta = Console.ReadLine();
            if (string.IsNullOrEmpty(numeroConta) || !int.TryParse(numeroConta, out _))
            {
                Console.WriteLine("Número de conta inválido. A criação da conta foi cancelada.");
                return;
            }

            BankAccount conta = new(numeroConta, cliente);
            contas.Add(conta);

            Console.WriteLine("Conta criada com sucesso!");
        }
    }
}