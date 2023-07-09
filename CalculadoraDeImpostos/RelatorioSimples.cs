using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    public class RelatorioSimples : RelatorioTemplate
    {
        protected override void ExibeCabecalho()
        {
            Console.WriteLine("".PadLeft(80, '='));
            Console.Write("BANCO DA ALURA");
            Console.WriteLine($"Emitido em: {DateTime.Now}".PadLeft(65));
            Console.WriteLine("".PadLeft(80, '='));
        }

        protected override void ExibeRodape()
        {
            Console.WriteLine("".PadLeft(80, '='));
            Console.WriteLine("+55(91)99999-9999".PadLeft(80));
            Console.WriteLine("".PadLeft(80, '='));
        }

        protected override void ListaContas(List<ContaBancaria> contas)
        {
            Console.WriteLine("TITULAR".PadLeft(25) + "SALDO".PadLeft(39));

            foreach (var item in contas)
            {
                Console.Write($"{contas.IndexOf(item) + 1} - {item.Titular}".PadRight(40));

                Console.ForegroundColor = item.Saldo < 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.WriteLine($"{item.Saldo}".PadLeft(25));
                Console.ResetColor();
            }

            Console.WriteLine();
        }
    }
}
