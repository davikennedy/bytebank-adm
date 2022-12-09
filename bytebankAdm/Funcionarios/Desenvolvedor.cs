using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario * 0.1;
        }

        public override double AumentarSalario()
        {
            return Salario *= 1.15;
        }

        public Desenvolvedor(string Cpf) : base(Cpf, 3000)
        {

        }
    }
}
