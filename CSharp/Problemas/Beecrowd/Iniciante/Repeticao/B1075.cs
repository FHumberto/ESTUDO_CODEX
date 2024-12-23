using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1075 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Resto 2");

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < 10000; i++)
        {
            if (i % n == 2)
            {
                Console.WriteLine(i);
            }
        }
    }
}
