using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento.Escudo
{
    class EscudoMadeira : Escudo
    {
        public EscudoMadeira()
        {
            base.setNome("Escudo de Madeira");
            base.setDefesa(10);
            base.setValor(5);
        }
    }
}
