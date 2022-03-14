using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using RPG.Equipamento;
using RPG.Equipamento.Arco;
using RPG.Equipamento.Escudo;
using RPG.Itens.Consumivel;
using RPG.Equipamento.Cajado;
using RPG.HabilidadeMagia.Magia;
using RPG.Criatura;

namespace RPG
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mago m = new Mago("Magui", 0);

            
        }

        public static void getExp(Monstro m, Heroi h)
        {
            if (m.getVivo()) return;

            int exp = m.dropExp();
            Console.WriteLine("{0} deu {1} EXP.", m.GetType(), exp);
            h.addExp(exp);
        }

        public static void testInv(Heroi m)
        {
            ArcoDeCaca ac = new ArcoDeCaca();
            ArcoLongo al = new ArcoLongo();
            Besta b = new Besta();
            CajadoAgua ca = new CajadoAgua();

            Pao pao = new Pao();


            m.inventario.mostrarConteudo();
            m.inventario.guardarIten(ac);
            m.inventario.guardarIten(al);
            m.inventario.guardarIten(pao);
            m.inventario.guardarIten(pao);
            m.inventario.guardarIten(pao);
            m.inventario.guardarIten(pao);
            m.inventario.guardarIten(pao);
            m.inventario.guardarIten(pao);
            m.inventario.guardarIten(al);

            m.inventario.mostrarConteudo();
        }
        public static void testExp(Mago m)
        {
            Dragao d = new Dragao(1);
            Aranha a = new Aranha(1);
            Goblin g = new Goblin(1);

            Cajado cajado = new CajadoAgua();

            m.equiparMaoDir(cajado);

            Magia magia = m.AtaqueMagico();

            Console.WriteLine("\nNome: {0} \nExp: {1}", m.nome, m.getExp());

            Console.WriteLine("Magia de {0} conjurada, com {1} de poder de ataque.\n", magia.getElemento(), magia.getDano());

            Console.WriteLine("\nDragao vida: {0}", d.status.getVida());
            d.RecebeAtaque(magia);
            Console.WriteLine("Dragao vida: {0}", d.status.getVida());
            getExp(d, m);

            Console.WriteLine("\nAranha vida: {0}", a.status.getVida());
            a.RecebeAtaque(magia);
            Console.WriteLine("Aranha vida: {0}", a.status.getVida());
            getExp(a, m);

            Console.WriteLine("\nGoblin vida: {0}", g.status.getVida());
            g.RecebeAtaque(magia);
            Console.WriteLine("Goblin vida: {0}", g.status.getVida());
            getExp(g, m);

            Console.WriteLine("\nNome: {0} \nExp: {1}", m.nome, m.getExp());
        }
    }
}
