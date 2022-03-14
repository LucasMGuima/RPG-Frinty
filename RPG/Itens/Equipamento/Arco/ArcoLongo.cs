using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento.Arco
{
    class ArcoLongo : ArmaDistancia
    {
        public ArcoLongo()
        {
            base.setNome("Arco Longo");
            base.setAtaque(20);
            base.setVelocidade(1.5f);
            base.setAlcance(20);
            base.setValor(25);
        }
    }
}
