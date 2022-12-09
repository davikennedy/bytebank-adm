using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebankAdm.Funcionarios;

namespace bytebankAdm.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(Autenticavel funcionario, string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine($"Bem-vindo ao sistema, {funcionario.Nome}!");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário e/ou senha incorretos!");
                return false;
            }
        }
    }
}
