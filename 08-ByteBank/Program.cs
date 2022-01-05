using _08_ByteBank.Funcionarios;

namespace _08_ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            
            Funcionario carlos = new Funcionario();

            carlos.Nome = "Carlos";
            carlos.CPF = "28371283";
            carlos.Salario = 2000;

            gerenciador.Registrar(carlos);

            Diretor Roberta = new Diretor();

            carlos.Nome = "Roberta";
            carlos.CPF = "2342341283";
            carlos.Salario = 5000;

            gerenciador.Registrar(Roberta);
        }
    }
}