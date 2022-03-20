using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;
using RPG.Equipamento.Cajado;

using RPG.HabilidadeMagia.Magia;

using RPG.Assets;

namespace RPG
{
    internal class Mago : Heroi
    {
        private int mana;
        public Mago(string nome, int idd)
        {
            base.nome = nome;
            base.idd = idd;
            base.level = 0;
            this.mana = 100;

            //status base da classe
            Status status = new Status(40, 20, 15, 20, 160, 20, 40);
            base.setStatus(status);

            //iten quipaveis da calsse
            Iten[] iten = { new Cajado() };
            this.setEquipavel(iten);
        }

        public new float Ataque()
        {
            float atk = base.Ataque();

            Iten maoEsq = base.slots.getMaoEsq();
            Iten maoDir = base.slots.getMaoDir();

            //checa se possui um cajado, se n possuir retorna o ataque padrão, se possuir um em alguma mão aplica o ataque dele ao atk padrao
            if(!maoDir.GetType().IsSubclassOf(typeof(Cajado)) && !maoEsq.GetType().IsSubclassOf(typeof(Cajado)))
            {
                return atk;
            }else if (maoDir.GetType().IsSubclassOf(typeof(Cajado))){
                Cajado cajado = (Cajado) maoDir;
                atk += cajado.getAtaque();
                Console.WriteLine("Atk -> {0}", atk);
                return atk;
            }else if (maoEsq.GetType().IsSubclassOf(typeof(Cajado)))
            {
                Cajado cajado = (Cajado)maoEsq;
                atk += cajado.getAtaque();
                Console.WriteLine("Atk -> {0}", atk);
                return atk;
            }

            return atk;
        }

        public Magia AtaqueMagico()
        {
            Iten maoEsq = base.slots.getMaoEsq();
            Iten maoDir = base.slots.getMaoDir();

            Magia magia = new Magia(Assets.Elemento.Normal, 0);

            //checa se possui um cajado, se n possuir retorna "nada".
            if (maoDir.GetType().IsSubclassOf(typeof(Cajado)) || maoEsq.GetType().IsSubclassOf(typeof(Cajado)))
            {
                //se estiver sem mana n conjura
                if (mana == 0)
                {
                    Console.WriteLine("Você esta sem mana para conjurar a magia");
                    return magia;
                }

                //conjura a magia
                this.mana -= 10;
                if (maoDir.GetType().IsSubclassOf(typeof(Cajado)))
                {
                    magia = conjurarMagia(maoDir);
                }
                else if (maoEsq.GetType().IsSubclassOf(typeof(Cajado)))
                {
                    magia = conjurarMagia(maoEsq);
                }
                return magia;
            }

            Console.WriteLine("Você precisa equipar um cajado para poder conjurar uma magia.");
            return magia;
        }

        public void Cura()
        {
            if(base.getStatus().getVida() == base.getStatus().getMaxVida()) {
                Console.WriteLine("[Alerta] {0} já está com a vida maxima", base.nome);
                return;
            }
            if (this.mana > 0)
            {
                float randNum = (float)(new Random(DateTime.Now.Millisecond).Next(10, this.getStatus().Sorte)) / 100;
                int cura = (int) Math.Round(base.getStatus().getVida() * randNum);
                this.mana = this.mana - 10;
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
    
        //FUCOES PRIVADAS   
        private float calcularAtkMagico()
        {
            //calcula o dano da magia
            float atk = 0;
            float randNum = 1 + (float)(new Random(DateTime.Now.Millisecond).Next(base.getStatus().Sorte)) / 100;
            //Console.WriteLine("Rand -> " + randNum);
            atk = (base.getStatus().Inteligencia + base.getStatus().Sabedoria) * randNum;
            atk = (float) Math.Floor(atk);
            Console.WriteLine("\nAtk Magico -> " + atk);

            return atk;
        }

        private Magia conjurarMagia(Iten iten)
        {
            Magia magia;

            Cajado cajado = (Cajado)iten;
            float atk = calcularAtkMagico();

            magia = new Magia(cajado.getElemento(), atk);

            return magia;
        }
    }

}
