using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1020 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Idade em Dias");

        int dias = int.Parse(Console.ReadLine());

        Console.WriteLine($"{dias / 365} ano(s)");
        Console.WriteLine($"{dias % 365 / 30} mes(es)");
        Console.WriteLine($"{dias % 365 % 30} dia(s)");
    }
}
