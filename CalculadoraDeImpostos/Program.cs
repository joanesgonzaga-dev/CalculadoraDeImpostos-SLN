using System;
using System.Collections.Generic;

namespace CalculadoraDeImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Instancia Orcamento
            Orcamento orcamento = new Orcamento();
            orcamento.AdicionaItem(new Item("CANETA", 250));
            orcamento.AdicionaItem(new Item("LAPIS", 200));
            orcamento.AdicionaItem(new Item("MOCHILA", 100));
            orcamento.AdicionaItem(new Item("MOCHILA", 100));
            orcamento.AdicionaItem(new Item("LANCHEIRA", 150));
            orcamento.AdicionaItem(new Item("BORRACHA", 50));
            #endregion

            #region Instancia Lista de ContaBancaria
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
            #endregion

            ICMS icms = new ICMS(new ISS());
            double taxa = icms.Calcula(orcamento);

            Console.WriteLine($"Total de Impostos:{taxa:C2}");
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
        private static void ExibeMenuRelatorios(List<ContaBancaria> contas)
        {
            string read = string.Empty;
            do
            {
                Console.WriteLine("Selecione o modelo de relatório \n(S - Simples, C - Completo): ");
                read = Console.ReadLine();

                if (read.Equals("S"))
                {
                    Console.Clear();
                    RelatorioSimples relatorioSiples = new RelatorioSimples();
                    relatorioSiples.ExibirRelatorio(contas);
                }

                else if (read.Equals("C"))
                {
                    Console.Clear();
                    RelatorioComplexo relatorioComplexo = new RelatorioComplexo();
                    relatorioComplexo.ExibirRelatorio(contas);
                }

                else if (read.Equals("q") || read.Equals("Q"))
                {
                    Console.Clear();
                    break;
                }

                else
                {
                    Console.Clear();
                }

            } while (read != "q" || read != "Q");

            Console.WriteLine("Pressione uma tecla para fechar...");
            Console.ReadKey();
        }

    }
}
