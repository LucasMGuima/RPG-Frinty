using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento.Escudo
{
    class EscudoAco : Escudo
    {
        public EscudoAco()
        {
            base.setNome("Escudo de Aço");
            base.setDefesa(25);
            base.setValor(40);
        }
    }
}
