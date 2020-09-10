using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario zeah = new Designer("111111");
            zeah.nome = "zé";
            zeah.Salario = 789;

            Diretor maria = new Diretor("11111");
            maria.nome = "maria";
            maria.Salario = 5;

            gerenciador.Registrar(maria);
            gerenciador.Registrar(zeah);

            Console.WriteLine(maria.GetBonificacao());
            Console.ReadLine();

        }
    }
}
