using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public abstract class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public abstract double getBonificacao();
        public abstract double aumentarSalario();
        public virtual double getPremioSemestral()
        {
            return Salario * 0.2;
        }

        public Funcionario(string Cpf, double Salario)
        {
            this.Cpf = Cpf;
            this.Salario = Salario;
            TotalFuncionarios++;
        }
        public static int TotalFuncionarios { get; set; }
    }
}
