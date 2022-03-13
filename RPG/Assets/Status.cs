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
        public int Inteligencia;
        public int Sabedoria;
        private float Vida;
        private float MaxVida;

        public Status(int forca, int def, int agi, int sorte, int vida, int sab, int inte)
        {
            this.Forca = forca;
            this.Defesa = def;
            this.Agilidade = agi;
            this.Sorte = sorte;
            this.Vida = vida;
            this.MaxVida = vida;
            this.Inteligencia = inte;
            this.Sabedoria = sab;
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
