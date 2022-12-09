using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public string Senha { get; set; }
        public bool Autenticar(string Senha)
        {
            return this.Senha == Senha;
        }
        public override double GetBonificacao()
        {
            return Salario * 0.25;
        }

        public override double GetPremioSemestral()
        {
            return Salario + base.GetPremioSemestral();
        }

        public override double AumentarSalario()
        {
            return Salario *= 1.05;
        }

        public GerenteDeContas(string Cpf) : base(Cpf, 4000) 
        {

        }
    }
}
