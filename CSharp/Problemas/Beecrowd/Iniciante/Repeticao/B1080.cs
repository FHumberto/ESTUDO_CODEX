using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1080 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Maior e Posição");

        int[] numeros = new int[100];
        int maior = 0;
        int posicao = 0;

        for (int i = 0; i < numeros.Length; i++)
        {
            numeros[i] = int.Parse(Console.ReadLine());

            if (numeros[i] > maior)
            {
                maior = numeros[i];
                posicao = i + 1;
            }
        }

        Console.WriteLine(maior);
        Console.WriteLine(posicao);
    }
}
