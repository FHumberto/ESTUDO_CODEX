using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1132 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Múltiplos de 13");

        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        int min = Math.Min(x, y);
        int max = Math.Max(x, y);
        int somatorio = 0;

        for (int i = min; i <= max; i++)
        {
            if (i % 13 != 0)
            {
                somatorio += i;
            }
        }

        Console.WriteLine(somatorio);
    }
}
