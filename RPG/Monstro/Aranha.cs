using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Criatura
{
    internal class Aranha : Monstro
    {
        public Aranha(int level)
        {
            Status status = new Status(20, 5, 35, 10, 40, 15, 10);
            base.status = status;

            base.setLevel(level);
            base.setBaseExp(20);
        }
    }
}
