using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;

namespace RPG.Monstro
{
    internal class Monstro
    {
        public int level;
        public Status status;

        public float Ataque()
        {
            float atk = 0;
            float randNum = 1 + (float)(new Random(DateTime.Now.Millisecond).Next(this.status.Sorte)) / 100;
            //Console.WriteLine("Rand -> " + randNum);
            atk = (this.status.Forca + this.status.Agilidade) * randNum;
            Console.WriteLine("Atk -> " + atk);
            return atk;
        }

        public float Defesa()
        {
            float def = 0;
            float randNum = 1 + (float)(new Random(DateTime.Now.Millisecond).Next(this.status.Sorte)) / 100;
            //Console.WriteLine("Rand -> " + randNum);
            def = (this.status.Defesa + this.status.Agilidade) * randNum;
            Console.WriteLine("Def -> " + def);
            return def;
        }

        public void RecebeAtaque(int forcaDoAtaque)
        {
            float dano = this.Defesa() - forcaDoAtaque;
            if (dano < 0)
            {
                this.status.setVida(this.status.getVida() + dano);
                Console.WriteLine("Recebeu dano.");
                return;
            }
            Console.WriteLine("O ataque não passou pela defesa.");
        }
    }
}
