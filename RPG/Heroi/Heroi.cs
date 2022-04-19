using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;
using RPG.Equipamento;
using RPG.Assets.Inventario;

namespace RPG
{
    internal abstract class Heroi
    {
        public string nome;
        public int idd;
        public int level;
        private int exp = 0;
        private Status status;
        public SlotsEquipamento slots = new SlotsEquipamento();
        private Iten[] equipavel;
        public Bag inventario = new Bag(3);
        protected void setEquipavel(Iten[] equipavel)
        {
            this.equipavel = equipavel;
        }

        protected void setStatus(Status status)
        {
            this.status = status;
        }

        public int getExp()
        {
            return this.exp;
        }

        public Status getStatus()
        {
            return this.status;
        }

        public virtual float Ataque()
        {
            float atk = 0;
            float randNum = 1 + (float) (new Random(DateTime.Now.Millisecond).Next(this.status.Sorte)) / 100;
            //Console.WriteLine("Rand -> " + randNum);
            atk = (this.status.Forca + this.status.Agilidade) * randNum;
            atk = (float) Math.Floor(atk);
            Console.WriteLine("Atk -> " + atk);
            return atk;
        }

        public float Defesa()
        {
            float def = 0;
            float randNum = 1 + (float) (new Random(DateTime.Now.Millisecond).Next(this.status.Sorte)) / 100;
            //Console.WriteLine("Rand -> " + randNum);
            def = (this.status.Defesa + this.status.Agilidade) * randNum;
            def = (float) Math.Floor(def);
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
    
        public void equiparMaoEsq(Iten equip)
        {
            if(podeEquipar(equip)) this.slots.setMaoEsq(equip);
        }

        public void equiparMaoDir(Iten equip)
        {
            if (podeEquipar(equip)) this.slots.setMaoDir(equip);
        }

        public void addExp(int exp)
        {
            this.exp += exp;
            //logica para apssar de nivel
        }

        private bool podeEquipar(Iten equip)
        {
            int size = this.equipavel.Length;
            //Console.WriteLine("Size -> {0}", size);
            for(int i = 0; i<size; i++)
            {
                //Console.WriteLine("{0} -> {1}", i, this.equipavel[i]);
                if (equip.GetType().IsSubclassOf(this.equipavel[i].GetType()))
                {
                    return true;
                }
            }
            Console.WriteLine("{0} não pode ser equipado pela sua classe.", equip.getNome());
            return false;
        }
    }
}
