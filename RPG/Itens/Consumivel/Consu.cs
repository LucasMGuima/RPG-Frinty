using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;

namespace RPG.Itens.Consumivel
{
    class Consu : Iten
    {
        private string mnsgEfeito;

        public Consu(string nome, int valor, bool estacavel, string mnsgEfeito)
        {
            base.setNome(nome);
            base.setValor(valor);
            base.setEstacavel(estacavel);
            this.mnsgEfeito = mnsgEfeito;
        }

        public virtual void Efeito(Heroi h) { }

        public string QualEfeito()
        {
            return this.mnsgEfeito;
        }
    }
}
