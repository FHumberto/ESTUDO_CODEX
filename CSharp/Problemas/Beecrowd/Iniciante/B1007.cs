using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;

internal class B1007 : Problema
{
    public override void PMain(string problema)
    {
        ProcedureHelpers.Cabecalho("1007", "Diferença");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());

        int diferenca = (a * b) - (c * d);

        Console.WriteLine($"DIFERENCA = {diferenca}");
    }
}
