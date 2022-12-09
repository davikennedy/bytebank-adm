using bytebankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {        
        public string Senha { get; set; }
        public string Login { get; set; }
        public bool Autenticar(string Login, string Senha)
        {
            return this.Senha == Senha && this.Login == Login;
        }

        public Autenticavel(string Cpf, double Salario) : base(Cpf, Salario)
        {
        }
    }
}
