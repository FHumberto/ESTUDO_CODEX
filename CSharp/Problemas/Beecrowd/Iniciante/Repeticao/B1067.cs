using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1067 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Números Ímpares");

        int x = int.Parse(Console.ReadLine());

        for (int i = 1; i <= x; i++)
        {
            if (i % 2 != 0)
            {
                Console.WriteLine(i);
            }
        }
    }
}
