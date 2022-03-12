using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Equipamento.Cajado
{
    class Cajado : Arma
    {
        private Elemento elemento;
        private int alcance;

        protected void setElemento(Elemento elemento)
        {
            this.elemento = elemento;
        }
        public Elemento getElemento()
        {
            return elemento;
        }

        protected void setAlcance(int alcance)
        {
            this.alcance = alcance;
        }
        public int getAlcance()
        {
            return this.alcance;
        }
    }
}
