using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1016 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Distância");

        int distancia = int.Parse(Console.ReadLine());

        Console.WriteLine($"{distancia * 2} minutos");
    }
}
