using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using bytebankAdm.Funcionarios;
using bytebankAdm.ParceriaComercial;

namespace bytebankAdm.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(FuncionarioAutenticavel funcionarioAutenticavel, string login, string senha)
        {
            bool usuarioAutenticado = funcionarioAutenticavel.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine($"Bem-vindo ao sistema, {funcionarioAutenticavel.Nome}!");
                return true;
            }
            else
            {
                Console.WriteLine("Usuário e/ou senha incorretos!");
                return false;
            }
        }

        public bool Logar(ParceiroComercial parceiroComercial , string login, string senha)
        {
            bool usuarioAutenticado = parceiroComercial.Autenticar(login, senha);
            if (usuarioAutenticado)
            {
                Console.WriteLine($"Bem-vindo ao sistema, {parceiroComercial.Nome}!");
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
