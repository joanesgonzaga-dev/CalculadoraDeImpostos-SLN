using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto(Imposto outroImposto): base(outroImposto){}
        public ImpostoMuitoAlto(): base(){}

        public override double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.20 + CalculaOutroImposto(orcamento);
        }
    }
}
