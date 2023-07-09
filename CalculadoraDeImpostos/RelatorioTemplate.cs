using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    public abstract class RelatorioTemplate
    {
        public void ExibirRelatorio(List<ContaBancaria> contas)
        {
            ExibeCabecalho();
            ListaContas(contas);
            ExibeRodape();
        }
        protected abstract void ExibeCabecalho();
        protected abstract void ListaContas(List<ContaBancaria> contas);
        protected abstract void ExibeRodape();
    }
}
