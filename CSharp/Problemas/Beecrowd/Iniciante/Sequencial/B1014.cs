using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1014 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Consumo");

        int distanciaTotal = int.Parse(Console.ReadLine());
        double distanciaPercorrida = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

        double consumo = distanciaTotal / distanciaPercorrida;

        Console.WriteLine($"{consumo.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)} km/l");
    }
}
