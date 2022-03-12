using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Monstro
{
    internal class Goblin : Monstro
    {
        public Goblin(int level)
        {
            Status status = new Status(35, 15, 20, 10, 50, 0);
            base.status = status;

            base.level = level;
        }
    }
}
