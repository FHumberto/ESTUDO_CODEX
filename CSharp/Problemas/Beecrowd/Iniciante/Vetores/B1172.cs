using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Vetores;

internal class B1172 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Substituição em Vetor I");

        int[] valores = new int[10];

        for (int i = 0; i < valores.Length; i++)
        {
            int numero = int.Parse(Console.ReadLine());

            valores[i] = (numero <= 0) ? 1 : numero;

            Console.WriteLine($"X[{i}] = {valores[i]}");
        }
    }
}
