using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento
{
    class Claymore : EspadaDuasMaos
    {
        public Claymore()
        {
            base.setNome("Calymore");
            base.setAtaque(40);
            base.setVelocidade(0.5f);
            base.setValor(35);
        }
    }
}
