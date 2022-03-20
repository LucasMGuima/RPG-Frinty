using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Itens.Consumivel
{
    class Vida : Consu
    {
        private int recuVida;
        public Vida(int recuVida, string nome, int valor, bool estacavel) : base(nome, valor, estacavel, "Recupera " + recuVida +"hp" )
        {
            this.recuVida = recuVida;
        }

        public override void Efeito(Heroi h)
        {
            float currVida = h.getStatus().getVida() + this.recuVida;
            if(currVida >= h.getStatus().getMaxVida())
            {
                h.getStatus().setVida(h.getStatus().getMaxVida());
            }
            else
            {
                h.getStatus().setVida(currVida);
            }
            Console.WriteLine("{0} usou {1} e recuperou {2} de vida.", h.nome, base.getNome(), this.recuVida);
        }
    }
}
