using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1142 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("PUM");

        int quantidade = int.Parse(Console.ReadLine());

        for (int linha = 0, i = 1; linha < quantidade; linha++, i += 4)
        {
            Console.WriteLine($"{i} {i + 1} {i + 2} PUM");
        }
    }
}
