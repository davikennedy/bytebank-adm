using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class Diretor : Funcionario
    {
        public override double getBonificacao()
        {
            return Salario + base.getBonificacao();
        }

        public override double getPremioSemestral()
        {
            return Salario + base.getPremioSemestral();
        }
    }
}
