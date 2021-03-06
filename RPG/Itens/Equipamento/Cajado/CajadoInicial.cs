using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Equipamento.Cajado
{
    class CajadoInicial : Cajado
    {
        public CajadoInicial()
        {
            base.setNome("Cajado Inicial");
            base.setVelocidade(1);
            base.setValor(10);
            base.setAlcance(10);
            base.setAtaque(5);

            Assets.Elemento elemento = Assets.Elemento.Normal;
            base.setElemento(elemento);
        }
    }
}
