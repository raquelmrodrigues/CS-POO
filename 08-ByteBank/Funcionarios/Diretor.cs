﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}