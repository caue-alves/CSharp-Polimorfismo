using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class GerenciadorBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario oFuncionario)
        {
           _totalBonificacao += oFuncionario.GetBonificacao();
        }

        public double GetBonificacao()
        {
            return _totalBonificacao;
        }
    }
}
