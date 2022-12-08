using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class Auxiliar : Funcionario
    {
        public override double getBonificacao()
        {
            return Salario * 0.2;
        }

        public override double getPremioSemestral()
        {
            return Salario + base.getPremioSemestral();
        }

        public override double aumentarSalario()
        {
            return Salario *= 1.1;
        }

        public Auxiliar(string Cpf) : base(Cpf, 2000)
        {

        }
    }
}
