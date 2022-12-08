using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class Designer : Funcionario
    {
        public override double getBonificacao()
        {
            return Salario * 0.17;
        }

        public override double getPremioSemestral()
        {
            return Salario + base.getPremioSemestral();
        }

        public override double aumentarSalario()
        {
            return Salario *= 1.11;
        }

        public Designer(string Cpf) : base(Cpf, 3000) 
        {

        }
    }
}
