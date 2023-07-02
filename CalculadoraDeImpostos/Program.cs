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
            CalculadoraDeDescontos calculadoraDeDescontos = new CalculadoraDeDescontos();

            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 200));
            orcamento.AdicionaItem(new Item("MOCHILA", 000));

            double desconto = calculadoraDeDescontos.Calcula(orcamento);

            Console.WriteLine($"O desconto é de: {desconto}");
            Console.ReadKey();
        }
    }
}
