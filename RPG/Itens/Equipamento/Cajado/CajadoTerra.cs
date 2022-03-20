using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Equipamento.Cajado
{
    class CajadoTerra : CajadoElemental
    {
        public CajadoTerra()
        {
            base.setNome("Cajado de Terra");
            base.setElemento(Assets.Elemento.Terra);
        }
    }
}