using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento
{
    class Arma : Iten
    {
        private int ataque;
        private float velocidade;

        protected void setAtaque(int ataque)
        {
            this.ataque = ataque;
        }
        public int getAtaque()
        {
            return this.ataque;
        }

        protected void setVelocidade(float velocidade)
        {
            this.velocidade = velocidade;
        }
        public float getVelocidade()
        {
            return this.velocidade;
        }
    }
}
