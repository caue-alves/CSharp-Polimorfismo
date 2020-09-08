using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string nome { get; set; }
        public string CPF { get;}
        public double Salario { get; set; }

        public Funcionario(string cpf)
        {
            CPF = cpf;
            TotalDeFuncionarios++;
            Console.WriteLine("Criando FUNCIONÁRIO...");
        }

        public virtual double GetBonificacao() 
        { 
            return Salario * 0.10;
        }
    }
}
