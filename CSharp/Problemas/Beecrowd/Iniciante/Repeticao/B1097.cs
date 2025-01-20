using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1097 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Sequencia IJ3");

        int j = 7;

        for (int i = 1; i <= 9; i += 2, j += 2)
        {
            Console.WriteLine($"I={i} J={j}");
            Console.WriteLine($"I={i} J={j - 1}");
            Console.WriteLine($"I={i} J={j - 2}");
        }
    }
}
