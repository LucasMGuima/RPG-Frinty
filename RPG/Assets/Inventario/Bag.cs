using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;
using RPG.Itens.Consumivel;
using RPG.Equipamento.Escudo;

namespace RPG.Assets.Inventario
{
    class Bag
    {
        private int espacos;
        private SlotInventario[] slot;

        public Bag(int espaco)
        {
            this.espacos = espaco;
            this.slot = new SlotInventario[this.espacos];

            for(int i = 0; i < espaco; i++)
            {
                this.slot[i] = new SlotInventario();
            }
        }

        public void guardarIten(Iten iten)
        {
            for(int i = 0; i < espacos; i++)
            {
                //se tiver nada no slot ja guarda
                if (this.slot[i].getQtd() == 0)
                {
                    this.slot[i].setIten(iten);
                    this.slot[i].setQtdIten(1);
                    Console.WriteLine("{0} guardao no slot {1}", iten.getNome(), i);
                    return;
                }

                //se o iten for igual ao iten no slot, ve se da para guardar ele ali
                if (iten.getNome().Equals(slot[i].getIten().getNome()))
                {
                    if (iten.getEstacavel())
                    {
                        slot[i].setQtdIten(1);
                        Console.WriteLine("{0} foi agrupado com os do mesmo tipo", iten.getNome());
                        return;
                    }
                }
            }

            Console.WriteLine("O inventario está cheio, n foi pocivel guardar {0}", iten.getNome());
        }

        public void usarIten(int itenId, Heroi h)
        {
            //usa o item na posiçõa itenId
            if(itenId >= this.espacos)
            {
                Console.WriteLine("O esapço desejado é maior que o tamanho da mochila");
                return;
            }

            SlotInventario slot = this.slot[itenId];
            //checa se o item é um consumivel ou equipamento
            if (slot.getIten().GetType().IsSubclassOf(typeof(Consu)))
            {
                //é um consumivel
                Consu consumivel = (Consu) slot.getIten();
                consumivel.Efeito(h); //aplica o efeito do consumivel
                this.slot[itenId].setQtdIten(-1); //decrementa o item usado
                return;
            }
            if(slot.getIten().GetType().IsSubclassOf(typeof(Arma)) || slot.getIten().GetType().IsSubclassOf(typeof(Escudo)))
            {
                //é um equipavel
                return;
            }
        }
        public void mostrarConteudo()
        {
            Console.WriteLine("---------INV----------");
            for(int i = 0; i < espacos; i++){
                Console.WriteLine("{0} -> {1} x{2}", i, slot[i].getIten().getNome(), slot[i].getQtd());
                if (slot[i].getIten().GetType().IsSubclassOf(typeof(Consu)))
                {
                    Consu consu = (Consu) slot[i].getIten();
                    Console.WriteLine("     {0}",consu.QualEfeito());
                }
            }
            Console.WriteLine("----------------------");
        }
    }
}
