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
        public bool Autenticar(string Senha)
        {
            return this.Senha == Senha;
        }

        public Autenticavel(string Cpf, double Salario) : base(Cpf, Salario)
        {
        }
    }
}
