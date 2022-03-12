using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;
using RPG.Equipamento.Arco;
using RPG.Equipamento.Escudo;
using RPG.Equipamento.Cajado;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Guerreiro g = new Guerreiro("Kyalin", 0);
            Espada espada = new EspadaCurta();
            Escudo escudo = new EscudoMadeira();
            Cajado cajado = new CajadoInicial();

            g.equiparMaoDir(espada);
            g.equiparMaoEsq(escudo);
            g.equiparMaoDir(cajado);
        }
    }
}
