using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Criatura
{
    internal class Dragao : Monstro
    {
        private Assets.Elemento elemento;
        public Dragao(int level)
        {
            Status status = new Status(50, 10, 25, 10, 80, 45, 30);
            base.status = status;

            base.setLevel(level);
            base.setBaseExp(100);

            this.elemento = Assets.Elemento.Fogo;

            base.fraqueza = Assets.Elemento.Agua;
            base.resisntencia = Assets.Elemento.Ar;
        }
    }
}
