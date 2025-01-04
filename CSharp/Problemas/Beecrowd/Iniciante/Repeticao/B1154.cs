using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1154 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Idades");

        int quantidadeDeCasos = 0;
        int idades = 0;

        while (true)
        {
            int dado = int.Parse(Console.ReadLine());

            if (dado < 0)
            {
                Console.WriteLine($"{((float)idades / quantidadeDeCasos).ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
                break;
            }

            idades += dado;
            quantidadeDeCasos++;
        }
    }
}
