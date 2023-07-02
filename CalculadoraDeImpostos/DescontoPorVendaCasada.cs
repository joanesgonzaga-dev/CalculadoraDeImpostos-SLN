using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get; set;}

        public double Desconta(Orcamento orcamento)
        {
                if (Existe(orcamento, "LAPIS") & Existe(orcamento, "CANETA"))
                {
                    return orcamento.Valor * 0.05;
                }
            return Proximo.Desconta(orcamento);
        }

        private bool Existe(Orcamento orcamento, string nomeItem)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Nome.Equals(nomeItem))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
