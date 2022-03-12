using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento.Arco
{
    class Besta : ArmaDistancia
    {
        public Besta()
        {
            base.setNome("Besta");
            base.setValor(15);
            base.setAtaque(20);
            base.setVelocidade(1);
            base.setAlcance(15);
        }
    }
}
