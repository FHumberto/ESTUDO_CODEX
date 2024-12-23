using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1073 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Quadrado de Pares");

        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine($"{i}^2 = {Math.Pow(i, 2)}");
            }
        }
    }
}
