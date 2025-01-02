using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1095 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Sequencia IJ 1");

        int i = 1;
        int j = 60;

        while (true)
        {
            if (j < 0)
                break;

            Console.WriteLine($"I={i} J={j}");
            i += 3;
            j -= 5;
        }
    }
}
