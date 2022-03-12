using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;
using RPG.Equipamento.Arco;

using RPG.Assets;

namespace RPG
{
    internal class Arqueiro : Heroi
    {
        private int qtdFlecha = 100;
        public Arqueiro(string nome, int idd)
        {
            base.nome = nome;
            base.idd = idd;
            base.level = 0;


            
            //status base da classe
            Status status = new Status(35, 20, 25, 20, 170, 30);
            base.setStatus(status);

            //itens quipaveis
            Iten[] iten = {new ArmaDistancia()};
            this.setEquipavel(iten);
        }

        public new float Ataque()
        {
            float atk = base.Ataque();
            Iten maoEsq = base.slots.getMaoEsq();
            Iten maoDir = base.slots.getMaoDir();

            //se estiver sem flechas retorna o ataque sem modificação
            if((this.qtdFlecha == 0))
            {
                return atk;
            }

            this.qtdFlecha -= 1;
            //se tiver flchas usa o arco
            if (maoEsq.GetType().IsSubclassOf(typeof(ArmaDistancia)))
            {
                Console.WriteLine("Somando valor da arma esq");
                ArmaDistancia tempArma = (ArmaDistancia) maoEsq;
                atk += tempArma.getAtaque();
            }else if (maoDir.GetType().IsSubclassOf(typeof(ArmaDistancia)))
            {
                Console.WriteLine("Somando valor da arma dir");
                ArmaDistancia tempArma = (ArmaDistancia) maoDir;
                atk += tempArma.getAtaque();
            }

            Console.WriteLine("Atk -> {0} Flehcas -> {1}", atk);
            return atk;
        }

        public void addFlecha(int qtdFlecha)
        {
            this.qtdFlecha += qtdFlecha;
        }
    }
}
