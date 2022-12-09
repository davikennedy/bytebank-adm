using bytebankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.SistemaInterno
{
    public interface IAutenticavel
    {
        public bool Autenticar(string Login, string Senha);
    }
}
