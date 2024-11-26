using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante;
internal class B1035 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Teste de Seleção 1");

        string[] linha = Console.ReadLine().Split(' ');
        int a = int.Parse(linha[0]);
        int b = int.Parse(linha[1]);
        int c = int.Parse(linha[2]);
        int d = int.Parse(linha[3]);

        string aceitos = (b > c && d > a && (c + d) > (a + b) && c > 0 && d > 0 && a % 2 == 0)
            ? "Valores aceitos"
            : "Valores nao aceitos";

        Console.WriteLine(aceitos);
    }
}
