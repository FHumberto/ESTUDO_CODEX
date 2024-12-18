using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1071 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Soma de Impares Consecutivos I");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int somatorio = 0;
        int inicial = Math.Min(a, b);
        int final = Math.Max(a, b);

        for (int i = inicial + 1; i < final; i++)
        {
            if (i % 2 != 0)
            {
                somatorio += i;
            }
        }

        Console.WriteLine(somatorio);
    }
}
