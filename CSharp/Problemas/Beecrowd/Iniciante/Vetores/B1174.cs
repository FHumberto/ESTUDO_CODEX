using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Vetores;

internal class B1174 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Selecao em Vetor I");

        for (int i = 0; i < 100; i++)
        {
            float numero = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            if (numero <= 10)
            {
                Console.WriteLine($"A[{i}] = {numero.ToString("F1", System.Globalization.CultureInfo.InvariantCulture)}");
            }
        }
    }
}
