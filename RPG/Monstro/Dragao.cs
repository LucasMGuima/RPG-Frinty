using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Monstro
{
    internal class Dragao : Monstro
    {
        public Dragao(int level)
        {
            Status status = new Status(50, 10, 25, 10, 80, 0, 0);
            base.status = status;

            base.level = level;
        }
    }
}
