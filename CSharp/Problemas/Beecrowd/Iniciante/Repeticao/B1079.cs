using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1079 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Médias Ponderadas");

        int casos = int.Parse(Console.ReadLine());

        for (int i = 0; i < casos; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');

            double a = double.Parse(linha[0], System.Globalization.CultureInfo.InvariantCulture);
            double b = double.Parse(linha[1], System.Globalization.CultureInfo.InvariantCulture);
            double c = double.Parse(linha[2], System.Globalization.CultureInfo.InvariantCulture);

            double media = ((a * 2) + (b * 3) + (c * 5)) / 10;

            Console.WriteLine(media.ToString("F1", System.Globalization.CultureInfo.InvariantCulture));
        }
    }
}
