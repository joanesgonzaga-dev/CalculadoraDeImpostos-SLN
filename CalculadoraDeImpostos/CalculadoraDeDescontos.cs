using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    public class CalculadoraDeDescontos
    {
        public double Calcula(Orcamento orcamento)
        {
            //Mais de 5 itens
            IDesconto d1 = new DescontoPorCincoItens();
            IDesconto d2 = new DescontoPorMaisDeQuinhentosReais();
            IDesconto d3 = new DescontoPorVendaCasada();
            IDesconto noDiscount = new SemDesconto();

            d1.Proximo = d2;
            d2.Proximo = d3;
            d3.Proximo = noDiscount;

            double desconto = d1.Desconta(orcamento);

            return desconto;
        }
    }
}
