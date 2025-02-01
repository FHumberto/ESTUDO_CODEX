using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Matrizes;

internal class B1182 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Coluna da Matriz");

        float[,] matriz = new float[12, 12];
        int coluna = int.Parse(Console.ReadLine());
        char operacao = char.Parse(Console.ReadLine());
        float somatorio = 0f;

        for (int i = 0; i < 12; i++)
        {
            for (int j = 0; j < 12; j++)
            {
                matriz[i, j] = float.Parse(Console.ReadLine());

                if (j == coluna)
                {
                    somatorio += matriz[i, j];
                }
            }
        }

        float total = (operacao == 'S') ? somatorio : somatorio / 12;
        Console.WriteLine(total.ToString("F1", System.Globalization.CultureInfo.InvariantCulture));
    }
}
