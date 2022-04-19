using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento
{
    abstract class Espada : Arma
    {
        private int qtdMao = 1;

        protected void setMao(int qtdMao)
        {
            this.qtdMao = qtdMao;
        }
        public int getMao()
        {
            return this.qtdMao;
        }
    }
}
