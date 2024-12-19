using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Selecao;

internal class B1065 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Pares entre Cinco Números");

        int pares = 0;

        for (int i = 0; i < 5; i++)
        {
            int valores = int.Parse(Console.ReadLine());
            if (valores % 2 == 0)
            {
                pares++;
            }
        }

        Console.WriteLine($"{pares} valores pares");
    }
}
