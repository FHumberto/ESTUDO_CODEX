using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1078 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Tabuada");

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{i} x {n} = {i * n}");
        }
    }
}
