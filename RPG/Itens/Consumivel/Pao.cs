using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;

namespace RPG.Itens.Consumivel
{
    class Pao : Iten
    {
        public Pao()
        {
            base.setNome("Pao");
            base.setValor(5);
        }
    }
}
