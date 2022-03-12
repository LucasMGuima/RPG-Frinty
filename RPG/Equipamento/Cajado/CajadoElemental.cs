using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento.Cajado
{
    class CajadoElemental : Cajado
    {
        public CajadoElemental()
        {
            base.setAtaque(10);
            base.setVelocidade(1.5f);
            base.setAlcance(15);
            base.setValor(20);
        }
    }
}
