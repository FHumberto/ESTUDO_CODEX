using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Matrizes;

internal class B1181 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Linha na Matriz");

        float[,] matriz = new float[12, 12];
        float somatorio = 0f;
        int linha = int.Parse(Console.ReadLine());
        char operacao = char.Parse(Console.ReadLine());

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                matriz[i, j] += float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

                if (i == linha)
                {
                    somatorio += matriz[i, j];
                }
            }
        }

        float total = (operacao == 'S') ? somatorio : somatorio / 12;

        Console.WriteLine(total.ToString("F1", System.Globalization.CultureInfo.InvariantCulture));
    }
}
