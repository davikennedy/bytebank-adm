﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Funcionarios
{
    public class Diretor : Funcionario
    {
        public double getBonificacao()
        {
            return Salario;  
        }
    }
}
