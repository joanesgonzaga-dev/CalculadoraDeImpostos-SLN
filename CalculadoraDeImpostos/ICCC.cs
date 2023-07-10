using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    public class ICCC : Imposto
    {
        public ICCC(Imposto outroImposto): base(outroImposto){ }
        public override double Calcula(Orcamento orcamento)
        {
            double valor = orcamento.Valor;
            double tax = 0.00;
            if (valor < 1000.00)
            {
                tax = valor * 0.05;
            }
            else if (valor >= 1000.00 && valor <= 3000.00)
            {
                tax = valor * 0.07;
            }
            else if(valor > 3000.00)
            {
                tax = (valor * 0.08) + 30.00;
            }

            return tax + CalculaOutroImposto(orcamento);
        }


        
    }
}
