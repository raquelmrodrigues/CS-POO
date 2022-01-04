namespace _06_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new ContaCorrente();

            Cliente cliente = new Cliente();
            cliente.Nome = "Matheus";
            cliente.CPF = "8939283292";
            cliente.Profissao = "pedreiro";

            conta.Titular = cliente;
            conta.Saldo = -10;
        }
    }
}