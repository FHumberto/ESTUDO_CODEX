using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1133 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Resto da Divisão");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        int min = Math.Min(a, b);
        int max = Math.Max(a, b);

        for (int i = min + 1; i < max; i++)
        {
            if (i % 5 == 2 || i % 5 == 3)
            {
                Console.WriteLine(i);
            }
        }
    }
}
