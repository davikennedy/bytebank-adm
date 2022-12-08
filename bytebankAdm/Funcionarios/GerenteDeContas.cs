using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class GerenteDeContas : Funcionario
    {
        public override double getBonificacao()
        {
            return Salario * 0.25;
        }

        public override double getPremioSemestral()
        {
            return Salario + base.getPremioSemestral();
        }

        public override double aumentarSalario()
        {
            return Salario *= 1.05;
        }

        public GerenteDeContas(string Cpf) : base(Cpf, 4000) 
        {

        }
    }
}
