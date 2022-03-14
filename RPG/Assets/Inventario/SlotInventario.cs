using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;

namespace RPG.Assets.Inventario
{
    class SlotInventario
    {
        private Iten iten = new Iten();
        private int qtdIten = 0;

        public SlotInventario()
        {
            this.iten = new Iten();
            this.qtdIten = 0;
        }

        public void setIten(Iten iten)
        {
            this.iten = iten;
        }

        public void setQtdIten(int qtd)
        {
            this.qtdIten += qtd;
        }

        public Iten getIten()
        {
            return this.iten;
        }

        public int getQtd()
        {
            return this.qtdIten;
        }
    }
}
