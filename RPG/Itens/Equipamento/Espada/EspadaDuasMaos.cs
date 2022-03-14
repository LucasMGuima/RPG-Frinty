using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento
{
    class EspadaDuasMaos : Espada
    {
        public EspadaDuasMaos()
        {
            base.setMao(2);
        }
    }
}
