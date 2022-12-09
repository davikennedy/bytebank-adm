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
        public bool Logar(Diretor funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine($"Bem-vindo ao sistema, {funcionario.Nome}!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }

        public bool Logar(GerenteDeContas funcionario, string senha)
        {
            
            if (funcionario.Autenticar(senha))
            {
                Console.WriteLine($"Bem-vindo ao sistema, {funcionario.Nome}!");
                return true;
            }
            else
            {
                Console.WriteLine("Senha incorreta!");
                return false;
            }
        }
    }
}
