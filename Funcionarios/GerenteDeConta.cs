using ByteBank.Sistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    class GerenteDeConta : Autenticavel
    {
        public GerenteDeConta(string cpf) : base(cpf)
        {
            Console.WriteLine("Criando GERENTE...");
        }
        public override double GetBonificacao()
        {
            return Salario + Salario * 1.20;
        }
    }
}
