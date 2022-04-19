using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento.Arco
{
    abstract class ArmaDistancia : Arma
    {
        private int alcance;

        protected void setAlcance(int alcance)
        {
            this.alcance = alcance;
        }
        public int getAlcance()
        {
            return alcance;
        }
    }
}
