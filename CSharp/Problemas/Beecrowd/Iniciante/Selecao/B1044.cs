using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Selecao;

internal class B1044 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Múltiplos");

        string[] linha = Console.ReadLine().Split(' ');

        int a = int.Parse(linha[0]);
        int b = int.Parse(linha[1]);

        string mensagem = (a % b == 0 || b % a == 0) ? "Sao Multiplos" : "Nao sao Multiplos";

        Console.WriteLine(mensagem);
    }
}
