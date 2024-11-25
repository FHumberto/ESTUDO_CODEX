using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;

internal class B1017 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Gasto de Combustível");

        int tempoGasto = int.Parse(Console.ReadLine());
        int velocidadeMedia = int.Parse(Console.ReadLine());
        float litros = (float)(tempoGasto * velocidadeMedia) / 12;

        Console.WriteLine($"{litros.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}
