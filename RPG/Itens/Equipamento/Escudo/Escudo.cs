using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento.Escudo
{
    abstract class Escudo : Iten
    {
        private int defesa;

        protected void setNome(string nome)
        {
            base.setNome(nome);
        }
        public string getNome()
        {
            return base.getNome();
        }

        protected void setDefesa(int defesa)
        {
            this.defesa = defesa;
        }
        public int getDefesa()
        {
            return this.defesa;
        }

        protected void setValor(int valor)
        {
            base.setValor(valor);
        }
        public int getValor()
        {
            return base.getValor();
        }
    }
}
