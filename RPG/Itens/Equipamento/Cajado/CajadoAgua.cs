using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Equipamento.Cajado
{
    class CajadoAgua : CajadoElemental
    {
        public CajadoAgua()
        {
            base.setNome("Cajado de Água");
            base.setElemento(Assets.Elemento.Agua);
        }
    }
}
