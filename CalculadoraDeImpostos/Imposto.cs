using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }
        public Imposto()
        {
            OutroImposto = null;
        }
        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }
        public abstract double Calcula(Orcamento orcamento);
        protected double CalculaOutroImposto(Orcamento orcamento)
        {
            if (OutroImposto == null) return 0.0;   
                return OutroImposto.Calcula(orcamento);
        }
    }
}
