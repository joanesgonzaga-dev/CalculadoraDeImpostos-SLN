namespace CalculadoraDeImpostos
{
    public class IKCV : Imposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (orcamento.Valor > 500 && ExisteItemAcimaDe100Reais(orcamento))
            {
                return orcamento.Valor * 0.01;
            }
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
