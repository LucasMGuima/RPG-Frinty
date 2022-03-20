using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Equipamento.Cajado
{
    class CajadoFogo : CajadoElemental
    {
        public CajadoFogo()
        {
            base.setNome("Cajado de Fogo");
            base.setElemento(Assets.Elemento.Fogo);
        }
    }
}
