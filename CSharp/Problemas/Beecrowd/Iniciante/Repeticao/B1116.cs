using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1116 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Dividindo X por Y");

        int casos = int.Parse(Console.ReadLine());

        for (int i = 0; i < casos; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');

            int a = int.Parse(linha[0]);
            int b = int.Parse(linha[1]);

            if (b == 0)
            {
                Console.WriteLine("divisao impossivel");
            }
            else
            {
                double divisao = (double)a / b;
                Console.WriteLine($"{divisao.ToString("F1", System.Globalization.CultureInfo.InvariantCulture)}");
            }
        }
    }
}
