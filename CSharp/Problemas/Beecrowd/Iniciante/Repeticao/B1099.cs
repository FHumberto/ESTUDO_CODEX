using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1099 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Soma de Ímpares Consecutivos II");

        int casos = int.Parse(Console.ReadLine());

        for (int i = 0; i < casos; i++)
        {
            string[] valores = Console.ReadLine().Split(' ');

            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            int somatorio = 0;

            int menor = Math.Min(x, y);
            int maior = Math.Max(x, y);

            for (int j = menor + 1; j < maior; j++)
            {
                if (j % 2 != 0)
                {
                    somatorio += j;
                }
            }

            Console.WriteLine(somatorio);
        }
    }
}
