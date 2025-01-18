using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Vetores;

internal class B1175 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Troca em Vetor I");

        int[] vetor = new int[20];

        for (int i = 0; i < 20; i++)
        {
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Array.Reverse(vetor);

        for (int i = 0; i < vetor.Length; i++)
        {
            Console.WriteLine($"N[{i}] = {vetor[i]}");
        }
    }
}
