using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;

internal class B1019 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Conversão de Tempo");

        int tempo = int.Parse(Console.ReadLine());

        Console.WriteLine($"{tempo / 3600}:{(tempo % 3600) / 60}:{tempo % 60}");
    }
}
