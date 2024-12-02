using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1059 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Números Pares");

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
