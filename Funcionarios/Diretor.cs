using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class Diretor : Funcionario
    {
        public Diretor(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando DIRETOR...");
        }
        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}
