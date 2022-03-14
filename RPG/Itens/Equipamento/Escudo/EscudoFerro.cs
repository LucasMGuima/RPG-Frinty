using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento.Escudo
{
    class EscudoFerro : Escudo
    {
        public EscudoFerro()
        {
            base.setNome("Escudo de Ferro");
            base.setDefesa(15);
            base.setValor(15);
        }
    }
}
