using ByteBank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank.Sistemas
{
    class SistemaInterno
    {
        public bool Logar(Diretor oHome, string senha)
        {
            bool UsuarioAutenticado = oHome.Autenticar(senha);

            if (UsuarioAutenticado)
            {
                Console.WriteLine("Você foi aceito!");
                return true;
            } else
            {
                Console.WriteLine("Errado, você não foi aceito");
                return false;
            }

        }
    }
}
