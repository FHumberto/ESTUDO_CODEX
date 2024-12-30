using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1144 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Sequência Lógica");

        int valor = int.Parse(Console.ReadLine());

        for (int i = 1; i <= valor; i++)
        {
            Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
            Console.WriteLine($"{i} {Math.Pow(i, 2) + 1} {Math.Pow(i, 3) + 1}");
        }
    }
}
