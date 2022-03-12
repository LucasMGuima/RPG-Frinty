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
    }
}
