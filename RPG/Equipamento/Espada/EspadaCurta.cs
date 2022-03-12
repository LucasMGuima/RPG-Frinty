using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento
{
    class EspadaCurta : Espada
    {
        public EspadaCurta()
        {
            base.setNome("Espada Curta");
            base.setAtaque(20);
            base.setVelocidade(1);
            base.setValor(10); 
        }
    }
}
