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
            Orcamento orcamento = new Orcamento(2500.00);

            Imposto icms = new ICMS();
            Imposto iss = new ISS();

            CalculadoraDeImposto calculadora = new CalculadoraDeImposto();

            calculadora.RealizaCalculo(orcamento, icms);
            calculadora.RealizaCalculo(orcamento, iss);

            Console.Read();
        }
    }
}
