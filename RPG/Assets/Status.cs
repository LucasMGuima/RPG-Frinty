using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Assets
{
    internal class Status
    {
        public int Forca;
        public int Defesa;
        public int Agilidade;
        public int Sorte;
        private float Vida;
        private float MaxVida;
        public int Mana;

        public Status(int forca, int def, int agi, int sorte, int vida, int mana)
        {
            this.Forca = forca;
            this.Defesa = def;
            this.Agilidade = agi;
            this.Sorte = sorte;
            this.Vida = vida;
            this.Mana = mana;
            this.MaxVida = vida;
        }

        public void setVida(float vida)
        {
            this.Vida = vida;
        }
        public float getVida()
        {
            return this.Vida;  
        }
        public float getMaxVida()
        {
            return this.MaxVida;
        }
    }
}
