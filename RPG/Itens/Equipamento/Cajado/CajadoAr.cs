using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Equipamento.Cajado
{
    class CajadoAr : CajadoElemental
    {
        public CajadoAr()
        {
            base.setNome("Cajado de Ar");
            base.setElemento(Assets.Elemento.Ar);
        }
    }
}
