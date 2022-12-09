using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class Designer : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario * 0.17;
        }

        public override double GetPremioSemestral()
        {
            return Salario + base.GetPremioSemestral();
        }

        public override double AumentarSalario()
        {
            return Salario *= 1.11;
        }

        public Designer(string Cpf) : base(Cpf, 3000) 
        {

        }
    }
}
