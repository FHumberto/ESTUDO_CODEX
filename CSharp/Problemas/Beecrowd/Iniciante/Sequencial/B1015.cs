using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Sequencial;

internal class B1015 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Distância Entre dois Pontos");

        double[] x = new double[2];
        double[] y = new double[2];

        for (int i = 0; i < 2; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            x[i] = float.Parse(linha[0], System.Globalization.CultureInfo.InvariantCulture);
            y[i] = float.Parse(linha[1], System.Globalization.CultureInfo.InvariantCulture);
        }

        double distancia = Math.Sqrt(Math.Pow(x[1] - x[0], 2) + Math.Pow(y[1] - y[0], 2));

        Console.WriteLine(distancia.ToString("F4", System.Globalization.CultureInfo.InvariantCulture));
    }
}
