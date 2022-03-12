using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;
using RPG.Equipamento.Cajado;

using RPG.Assets;

namespace RPG
{
    internal class Mago : Heroi
    {
        public Mago(string nome, int idd)
        {
            base.nome = nome;
            base.idd = idd;
            base.level = 0;

            //status base da classe
            Status status = new Status(40, 20, 15, 20, 160, 45);
            base.setStatus(status);

            //iten quipaveis da calsse
            Iten[] iten = { new Cajado() };
            this.setEquipavel(iten);
        }

        public void Cura()
        {
            if(base.getStatus().getVida() == base.getStatus().getMaxVida()) {
                Console.WriteLine("[Alerta] {0} já está com a vida maxima", base.nome);
                return;
            }
            if (base.getStatus().Mana > 0)
            {
                float randNum = (float)(new Random(DateTime.Now.Millisecond).Next(10, this.getStatus().Sorte)) / 100;
                int cura = (int) Math.Round(base.getStatus().getVida() * randNum);
                base.getStatus().Mana = base.getStatus().Mana - 10;
                Console.WriteLine("[-10 mp] {0} se curou em {1} hp.", base.nome, cura);
                float newVida = base.getStatus().getVida() + cura;
                if (newVida > base.getStatus().getMaxVida())
                {
                    base.getStatus().setVida(base.getStatus().getMaxVida());
                }
                else
                {
                    base.getStatus().setVida(newVida);
                }
            }
            else
            {
                Console.WriteLine("[AVISO] {0} está sem mana.", base.nome);
            }
        }
    }
}
