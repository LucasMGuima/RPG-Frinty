﻿using System;
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
            Mago m = new Mago("Magui", 0);
            Arqueiro a = new Arqueiro("Pripo", 0);

            Espada espada = new EspadaCurta();
            Escudo escudo = new EscudoMadeira();
            Cajado cajado = new CajadoInicial();
            ArmaDistancia arco = new ArcoLongo();

            Console.WriteLine("Guerreiro");
            g.equiparMaoDir(espada);
            g.equiparMaoEsq(escudo);
            g.equiparMaoDir(cajado);

            Console.WriteLine("\nMago");
            m.equiparMaoDir(cajado);
            m.equiparMaoEsq(espada);

            Console.WriteLine("\nArqueiro");
            a.equiparMaoEsq(espada);
            a.equiparMaoDir(arco);
        }
    }
}
