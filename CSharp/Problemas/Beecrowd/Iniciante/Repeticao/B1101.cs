using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1101 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Sequência de Números e Soma");

        while (true)
        {
            string[] linha = Console.ReadLine().Split(' ');

            int x = int.Parse(linha[0]);
            int y = int.Parse(linha[1]);

            if (x <= 0 || y <= 0)
                break;

            int menor = Math.Min(x, y);
            int maior = Math.Max(x, y);
            int somatorio = 0;

            for (int i = menor; i <= maior; i++)
            {
                Console.Write($"{i} ");
                somatorio += i;
            }

            Console.WriteLine($"Sum={somatorio}");
        };

    }
}
