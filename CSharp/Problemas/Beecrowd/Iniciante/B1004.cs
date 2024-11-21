using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;

internal class B1004 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Produto Simples");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"PROD = {a * b}");
    }
}