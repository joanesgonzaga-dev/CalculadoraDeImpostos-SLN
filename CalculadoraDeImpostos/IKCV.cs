namespace CalculadoraDeImpostos
{
    public class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(): base(){}
        public IKCV(Imposto outroImposto): base(outroImposto){}
        public override bool isUsarMaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && ExisteItemAcimaDe100Reais(orcamento);
        }
        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.01;
        }
        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
        
        private bool ExisteItemAcimaDe100Reais(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor > 100.00)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
