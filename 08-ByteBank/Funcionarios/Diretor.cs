using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        //construtor do diretor
        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("criando diretor");
        }
        
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
