using bytebankAdm.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public bool Autenticar(string Login, string Senha)
        {
            return this.Login == Login && this.Senha == Senha;
        }

        protected FuncionarioAutenticavel(string Cpf, double Salario) : base(Cpf, Salario)
        {
        }
    }
}
