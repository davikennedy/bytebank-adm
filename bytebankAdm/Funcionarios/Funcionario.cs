using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; set; }

        public virtual double getBonificacao()
        {
            return Salario * 0.1;
        }

        public virtual double getPremioSemestral()
        {
            return Salario * 0.2;
        }

        public Funcionario (string Cpf)
        {
            this.Cpf = Cpf;
            TotalFuncionarios++;
        }
        public static int TotalFuncionarios { get; set; }
    }
}
