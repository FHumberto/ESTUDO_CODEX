using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;

internal class B1010 : Problema
{
    public override void PMain(string problema)
    {
        ProcedureHelpers.Cabecalho("Cálculo Simples");

        int[] pecas = new int[2];
        double[] custo = new double[2];
        double total = 0;

        for (int i = 0; i < 2; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            _ = int.Parse(linha[0]);
            pecas[i] = int.Parse(linha[1]);
            custo[i] = double.Parse(linha[2], System.Globalization.CultureInfo.InvariantCulture);

            total += pecas[i] * custo[i];
        }

        Console.WriteLine($"VALOR A PAGAR: R$ {total.ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}
