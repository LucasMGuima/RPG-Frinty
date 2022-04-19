using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG.Equipamento
{
    abstract class Iten
    {
        private string nome;
        private int valor;
        //por padrão todo item é estacavel
        private bool estacavel = true;

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

        protected void setEstacavel(bool estacavel)
        {
            this.estacavel = estacavel;
        }
        public bool getEstacavel()
        {
            return this.estacavel;
        }
    }
}
