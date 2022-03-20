using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;

namespace RPG.Itens.Consumivel
{
    class Pao : Vida
    {
        public Pao() : base(5, "Pão", 1, true)
        {
        }
    }
}
