using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;

public class B1003 : Problema
{
    public override void PMain(string problema)
    {
        ProcedureHelpers.Cabecalho("Soma Simples");

        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine($"SOMA = {a + b}");
    }
}