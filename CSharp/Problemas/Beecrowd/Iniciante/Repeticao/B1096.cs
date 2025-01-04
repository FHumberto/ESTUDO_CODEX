using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1096 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Sequencia IJ 2");

        for (int i = 1; i < 10; i += 2)
        {
            Console.WriteLine($"I={i} J=7");
            Console.WriteLine($"I={i} J=6");
            Console.WriteLine($"I={i} J=5");
        }
    }
}
