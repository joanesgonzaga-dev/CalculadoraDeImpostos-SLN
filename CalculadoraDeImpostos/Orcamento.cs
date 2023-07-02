using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    public class Orcamento
    {
        public double Valor { get; private set; }
        public List<Item> Itens { get; set; }
        public Orcamento()
        {
            Itens = new List<Item>();
        }
        public Orcamento(double valor) : base()
        {
            Valor = valor;
        }
        public void AdicionaItem(Item item)
        {
            Itens.Add(item);
            Valor += item.Valor;
        }
    }
}
