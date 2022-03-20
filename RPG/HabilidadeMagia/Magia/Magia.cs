using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.HabilidadeMagia.Magia
{
    class Magia
    {
        private Assets.Elemento elemento;
        private float dano;

        public Magia(Assets.Elemento elemento, float dano)
        {
            this.elemento = elemento;
            this.dano = dano;
        }

        public Assets.Elemento getElemento()
        {
            return this.elemento;
        }

        public float getDano()
        {
            return this.dano;
        }
    }
}
