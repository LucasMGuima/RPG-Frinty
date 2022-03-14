using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento.Arco
{
    class ArcoDeCaca : ArmaDistancia
    {
        public ArcoDeCaca()
        {
            base.setNome("Arco de Caça");
            base.setValor(15);
            base.setAlcance(10);
            base.setValor(15);
            base.setVelocidade(2);
        }
    }
}
