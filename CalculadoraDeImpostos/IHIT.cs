using System.Collections.Generic;

namespace CalculadoraDeImpostos
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        public override bool isUsarMaximaTaxacao(Orcamento orcamento)
        {
            return ContaRepetidos(orcamento.Itens) > 1;
        }
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return (orcamento.Valor * 0.13) + 100.00;
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Itens.Count * 0.01;
        }
        private static int ContaRepetidos(List<Item> itens)
        {
            foreach (var item in itens)
            {
                int counter = 0;
                foreach (var subItem in itens)
                {
                    if (item.Nome == subItem.Nome)
                    {
                        counter++;
                    }
                }
                if (counter > 1)
                {
                    return counter;
                }
            }
            return 1;
        }
    }
}
