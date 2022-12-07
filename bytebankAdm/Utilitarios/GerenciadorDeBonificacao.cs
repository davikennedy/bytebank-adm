﻿using bytebankAdm.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebankAdm.Utilitarios
{
    public class GerenciadorDeBonificacao
    {
        private double _totalBonificacao;

        public void Registrar(Funcionario funcionario)
        {
            this._totalBonificacao += funcionario.getBonificacao();
        }

        public double getBonificacao()
        {
            return this._totalBonificacao;
        }
    }
}
