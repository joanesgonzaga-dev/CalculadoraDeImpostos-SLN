using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    public class RelatorioComplexo : RelatorioTemplate
    {
        protected override void ExibeCabecalho()
        {
            Console.WriteLine("".PadLeft(80, '='));
            Console.Write("BANCO DA ALURA");
            Console.WriteLine("+55(91)99999-9999".PadLeft(66));
            Console.WriteLine("ENDEREÇO: Avenida do Saber, nº 1024 - S.Valley");
            //Console.WriteLine($"Emitido em: {DateTime.Now}".PadLeft(65));
            Console.WriteLine("".PadLeft(80, '='));
        }

        protected override void ExibeRodape()
        {
            Console.WriteLine("".PadLeft(80, '='));
            Console.Write("EMAIL: atendimento@alura.com.br".PadLeft(30));
            Console.WriteLine($"Emitido em: {DateTime.Now}".PadLeft(49));
            Console.WriteLine("".PadLeft(80, '='));
        }

        protected override void ListaContas(List<ContaBancaria> contas)
        {
            Console.WriteLine("TITULAR".PadLeft(25) + "AGENCIA".PadLeft(25) + "Nº CONTA".PadLeft(15) + "SALDO".PadLeft(14));

            foreach (var item in contas)
            {
                Console.Write($"{contas.IndexOf(item) + 1} - {item.Titular}".PadRight(40));
                Console.Write($"{item.Agencia}".PadLeft(8) + $"{item.Conta}".PadLeft(16));

                Console.ForegroundColor = item.Saldo < 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.WriteLine($"{item.Saldo}".PadLeft(16));
                Console.ResetColor();
            }

            Console.WriteLine();
        }

    }
}
