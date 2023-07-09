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
            List<ContaBancaria> contas = new List<ContaBancaria>()
            {
                new ContaBancaria()
                {
                    Agencia = "1820",
                    Conta   = "316-05",
                    Titular = "FULANO DE TAL DA SILVA DAS ARABIAS",
                    Saldo   = 2800.00M
                },
                new ContaBancaria()
                {
                    Agencia = "2020",
                    Conta   = "658-02",
                    Titular = "CICLANO DA SILVA",
                    Saldo   = 1300.00M
                },

                new ContaBancaria()
                {
                    Agencia = "0598",
                    Conta   = "674-57",
                    Titular = "JOAO GASTAO",
                    Saldo   = -20.00M
                },

                new ContaBancaria()
                {
                    Agencia = "2020",
                    Conta   = "338-90",
                    Titular = "JOANES DE AVIZ",
                    Saldo   = 5300.00M
                }
            };

            RelatorioComplexo relatorioComplexo = new RelatorioComplexo();
            relatorioComplexo.ExibirRelatorio(contas);

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

        /*
         *
         Orcamento orcamento = new Orcamento();
            //orcamento.AdicionaItem(new Item("CANETA", 250));
            //orcamento.AdicionaItem(new Item("LAPIS", 200));
            //orcamento.AdicionaItem(new Item("MOCHILA", 100));
            //orcamento.AdicionaItem(new Item("MOCHILA", 100));
            //orcamento.AdicionaItem(new Item("LANCHEIRA", 150));
            //orcamento.AdicionaItem(new Item("BORRACHA", 50));

            //IHIT ihit = new IHIT();

            //double imposto = ihit.Calcula(orcamento);

            //Console.WriteLine($"Imposto: {imposto}");
            //Console.ReadKey();
        */
    }
}
