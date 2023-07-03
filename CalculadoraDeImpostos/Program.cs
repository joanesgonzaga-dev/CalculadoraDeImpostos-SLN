using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 200));
            orcamento.AdicionaItem(new Item("MOCHILA", 100));
            orcamento.AdicionaItem(new Item("MOCHILA", 100));
            orcamento.AdicionaItem(new Item("LANCHEIRA", 150));
            orcamento.AdicionaItem(new Item("BORRACHA", 50));

            IHIT ihit = new IHIT();

            double imposto = ihit.Calcula(orcamento);

            Console.WriteLine($"Imposto: {imposto}");
            Console.ReadKey();
        }


        private static void CalculaDescontos()
        {
            CalculadoraDeDescontos calculadoraDeDescontos = new CalculadoraDeDescontos();

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 200));
            orcamento.AdicionaItem(new Item("MOCHILA", 000));

            double desconto = calculadoraDeDescontos.Calcula(orcamento);

            Console.WriteLine($"O desconto é de: {desconto}");
            Console.ReadKey();
        }

        private static void CalculaImpostos()
        {
            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 200));
            orcamento.AdicionaItem(new Item("MOCHILA", 000));

            ICPP icpp = new ICPP();
            IKCV ikcv = new IKCV();

            Console.WriteLine($"ICPP: {icpp.Calcula(orcamento)}");
            Console.WriteLine($"IKCV: {ikcv.Calcula(orcamento)}");

            Console.ReadKey();
        }

        
    }
}
