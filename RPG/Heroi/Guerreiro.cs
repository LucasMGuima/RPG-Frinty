using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Assets;
using RPG.Equipamento;
using RPG.Equipamento.Escudo;

namespace RPG
{
    internal class Guerreiro : Heroi
    {
        public Guerreiro(string nome, int idd)
        {
            base.nome = nome;
            base.idd = idd;
            base.level = 0;

            //status base da classe
            Status status = new Status(55, 40, 10, 20, 175, 10, 5);
            base.setStatus(status);

            //tipos de item q pode equipar
            Iten[] equipavel = {new Escudo(), new Espada(), new EspadaDuasMaos()};
            base.setEquipavel(equipavel);
        }

        public override float Ataque()
        {
            float atk = 0;
            float randNum = 1 + (float)(new Random(DateTime.Now.Millisecond).Next(base.getStatus().Sorte)) / 100;
            //Console.WriteLine("Rand -> " + randNum);
            atk = (base.getStatus().Forca + base.getStatus().Agilidade) * randNum;
            atk = (float)Math.Floor(atk);
            Console.WriteLine("Atk base-> " + atk);

            //soma o ataque da arma se tiver alguma equipada
            //checa se é uma arma de duas mãos
            if (base.slots.getMaoDir().GetType().IsSubclassOf(typeof(EspadaDuasMaos)))
            {
                Arma tempArm = (Arma)base.slots.getMaoDir();
                Console.WriteLine("Aplicando dano da arma");
                atk += tempArm.getAtaque();
            }
            else
            {
                if (base.slots.getMaoDir().GetType().IsSubclassOf(typeof(Arma)))
                {
                    Arma tempArm = (Arma)base.slots.getMaoDir();
                    Console.WriteLine("Aplicando dano da arma na mão esquerda");
                    atk += tempArm.getAtaque();
                }
                if (base.slots.getMaoEsq().GetType().IsSubclassOf(typeof(Arma)))
                {
                    Arma tempArm = (Arma)base.slots.getMaoEsq();
                    Console.WriteLine("Aplicando dano da arma na mão direita");
                    atk += tempArm.getAtaque();
                }
            }
            
            Console.WriteLine("Atk mais dano arma-> " + atk);
            return atk;
        }

        public new float Defesa()
        {
            float def = 0;
            float randNum = 1 + (float)(new Random(DateTime.Now.Millisecond).Next(base.getStatus().Sorte)) / 100;
            //Console.WriteLine("Rand -> " + randNum);
            def = (base.getStatus().Defesa + base.getStatus().Agilidade) * randNum;
            def = (float)Math.Floor(def);
            Console.WriteLine("Def -> " + def);
            //aplica o escudo se usando
            Iten maoEsq = base.slots.getMaoEsq();
            Iten maoDir = base.slots.getMaoDir();

            if (maoEsq.GetType().IsSubclassOf(typeof(Escudo)))
            {
                Escudo escudo = (Escudo) maoEsq;
                def += escudo.getDefesa();
            }
            if (maoDir.GetType().IsSubclassOf(typeof(Escudo)))
            {
                Escudo escudo = (Escudo)maoDir;
                def += escudo.getDefesa();
            }

            Console.WriteLine("Def -> " + def);
            return def;
        }


    }
}
