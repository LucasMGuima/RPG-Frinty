using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;

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

        public void mostrarConteudo()
        {
            Console.WriteLine("---------INV----------");
            for(int i = 0; i < espacos; i++){
                Console.WriteLine("{0} -> {1} x{2}", i, slot[i].getIten().getNome(), slot[i].getQtd());
            }
            Console.WriteLine("----------------------");
        }
    }
}
