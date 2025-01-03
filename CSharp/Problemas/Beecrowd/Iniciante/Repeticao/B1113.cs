using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1113 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Crescente e Decrecente");

        while (true)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int x = int.Parse(linha[0]);
            int y = int.Parse(linha[1]);

            if (x == y)
                break;

            string resposta = (y > x) ? "Crescente" : "Decrescente";

            Console.WriteLine(resposta);
        }
    }
}
