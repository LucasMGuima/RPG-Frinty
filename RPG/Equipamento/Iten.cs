using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento
{
    class Iten
    {
        private string nome;
        private int valor;

        protected void setNome(string nome)
        {
            this.nome = nome;
        }
        public string getNome()
        {
            return this.nome;
        }

        protected void setValor(int valor)
        {
            this.valor = valor;
        }
        public int getValor()
        {
            return this.valor;
        }
    }
}
