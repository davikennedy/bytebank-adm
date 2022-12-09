using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public override double getBonificacao()
        {
            return Salario * 0.1;
        }

        public override double aumentarSalario()
        {
            return Salario *= 1.15;
        }

        public Desenvolvedor(string Cpf) : base(Cpf, 3000)
        {

        }
    }
}
