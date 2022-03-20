using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Itens.Consumivel
{
    class Queijo : Consu
    {
        public Queijo() : base("Queijo", 10, true, "Recupera 10hp") { }


        public override void Efeito(Heroi h)
        {
            //recupera em 10 o heiro
            
        }
    }
}
