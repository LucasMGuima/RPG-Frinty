using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;
using RPG.HabilidadeMagia.Magia;
using RPG.Equipamento;
using RPG.Itens.Consumivel;
using RPG.Equipamento.Arco;
using RPG.Equipamento.Cajado;
using RPG.Equipamento.Escudo;

namespace RPG.Criatura
{
    internal abstract class Monstro
    {
        private bool vivo = true;
        private int baseExp;
        private int level;

        public Status status;
        public Assets.Elemento fraqueza = Assets.Elemento.Normal;
        public Assets.Elemento resisntencia = Assets.Elemento.Normal;

        protected void setBaseExp(int baseExp)
        {
            this.baseExp = baseExp;
        }
        protected void setLevel(int level)
        {
            if (level <= 0) level = 1;
            this.level = level;
        }

        public bool getVivo()
        {
            return this.vivo;
        }

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
                if (Vivo(this.status.getVida())) return;
                else
                {
                    Console.WriteLine("Morreu.");
                    return;
                }
            }
            Console.WriteLine("O ataque não passou pela defesa.");
        }

        public void RecebeAtaque(Magia magia)
        {
            float magicDef = (float) Math.Floor(this.status.Inteligencia * calcResistencia(magia.getElemento()));
            float magicFraq = (float)Math.Floor(magia.getDano() * calcFraqueza(magia.getElemento()));

            float magicDano = (this.status.Inteligencia + magicDef) - (magia.getDano() + magicFraq);

            if(magicDano < 0)
            {
                this.status.setVida(this.status.getVida() + magicDano);
                Console.WriteLine("{0} -> Recebeu dano.",this.GetType());
                if (Vivo(this.status.getVida())) return;
                else
                {
                    Console.WriteLine("{0} -> Morreu.",this.GetType());
                    return;
                }
            }
            Console.WriteLine("O ataque não passou pela defesa");

        }

        public int dropExp()
        {
            return this.baseExp*this.level;
        }

        public Iten dropIten()
        {
            //aplicar logica de escolha do drop com base em uma "loot-table"
            Iten[] lootTable = { new Pao(), new Claymore(), new  CajadoAr(), new ArcoDeCaca()};
            int size = lootTable.Length;

            int numRand = new Random().Next(size);
            Iten drop = lootTable[numRand];

            return drop;
        }

        //FUNCOES PRIVADAS
        private float calcResistencia(Assets.Elemento elementoAtak)
        {
            float resisElement = 0;

            //se ele for resistente aquele elemento
            if(elementoAtak == resisntencia)
            {
                resisElement = 0.25f;
            }

            return resisElement;
        }

        private float calcFraqueza(Assets.Elemento elementoAtak)
        {
            float farqElement = 0;

            //se ele for resistente aquele elemento
            if (elementoAtak == fraqueza)
            {
                farqElement = 0.25f;
            }

            return farqElement;
        }

        private bool Vivo(float vida)
        {
            if (vida <= 0)
            {
                this.vivo = false;
                return false;
            }
            return true;
        }
    }
}
