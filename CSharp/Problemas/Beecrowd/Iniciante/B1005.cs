using Beecrowd.Template;
using Beecrowd.Util;
using System.Globalization;

namespace Beecrowd.Iniciante;

public class B1005 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Média 1");

        double a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        double media = ((a * 3.5) + (b * 7.5)) / 11;

        Console.WriteLine($"MEDIA = {media.ToString("F5", CultureInfo.InvariantCulture)}");
    }
}