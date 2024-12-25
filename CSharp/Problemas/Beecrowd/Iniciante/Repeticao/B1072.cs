using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1072 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Intervalo 2");

        int valores = int.Parse(Console.ReadLine());
        int quantidadeIn = 0;
        int quantidadeOut = 0;

        for (int i = 0; i < valores; i++)
        {
            int numero = int.Parse(Console.ReadLine());

            if (numero >= 10 && numero <= 20)
            {
                quantidadeIn++;
            }
            else
            {
                quantidadeOut++;
            }
        }

        Console.WriteLine($"{quantidadeIn} in");
        Console.WriteLine($"{quantidadeOut} out");
    }
}
