using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento
{
    class Adaga : Espada
    {
        public Adaga()
        {
            base.setNome("Adaga");
            base.setAtaque(10);
            base.setVelocidade(2);
            base.setValor(5);
        }
    }
}
