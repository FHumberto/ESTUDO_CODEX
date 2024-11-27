using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1011 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Esfera");

        const double PI = 3.14159;
        double raio = double.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);
        double volume = 4 / 3.0 * PI * Math.Pow(raio, 3);
        Console.WriteLine($"VOLUME = {volume.ToString("F3", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}
