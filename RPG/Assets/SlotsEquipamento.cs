using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;

namespace RPG.Assets
{
    class SlotsEquipamento
    {
        private Iten maoEsq = new Iten();
        private Iten maoDir = new Iten();

        public void setMaoEsq(Iten iten)
        {
            //se tiver com um item de duas maos equipado desequipa da outra mao
            if (maoEsq.GetType().IsSubclassOf(typeof(EspadaDuasMaos)))
            {
                this.maoDir = null;
            }
            this.maoEsq = iten;
            //se for uma espada de duas maos equipa nas duas;
            if (iten.GetType().IsSubclassOf(typeof(EspadaDuasMaos)))
            {
                this.maoDir = iten;
            }

            Console.WriteLine("{0} foi equipado na mão esquerda.", iten.getNome());
        }
        public Iten getMaoEsq()
        {
            return this.maoEsq;
        }

        public void setMaoDir(Iten iten)
        {
            //se tiver com um item de duas maos equipado desequipa da outra mao
            if (maoDir.GetType().IsSubclassOf(typeof(EspadaDuasMaos)))
            {
                this.maoEsq = null;
            }
            this.maoDir = iten;
            //se for uma espada de duas maos equipa nas duas;
            if (iten.GetType().IsSubclassOf(typeof(EspadaDuasMaos)))
            {
                this.maoEsq = iten;
            }
            
            Console.WriteLine("{0} foi equipado na mão direita.", iten.getNome());
        }
        public Iten getMaoDir()
        {
            return this.maoDir;
        }
    }
}
