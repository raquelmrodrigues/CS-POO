using _08_ByteBank.Funcionarios;

namespace _08_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            Funcionario carlos = new Funcionario("3764372846");

            carlos.Nome = "Carlos";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor roberta = new Diretor();

            roberta.Nome = "Roberta";
            roberta.Salario = 5000;

            gerenciador.Registrar(Roberta);
        }
    }
}