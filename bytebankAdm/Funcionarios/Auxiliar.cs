using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public override double GetBonificacao()
        {
            return Salario * 0.2;
        }

        public override double GetPremioSemestral()
        {
            return Salario + base.GetPremioSemestral();
        }

        public override double AumentarSalario()
        {
            return Salario *= 1.1;
        }

        public Auxiliar(string Cpf) : base(Cpf, 2000)
        {

        }
    }
}
