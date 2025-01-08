using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1143 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Quadrado e ao Cubo");

        int valor = int.Parse(Console.ReadLine());

        for (int i = 1; i <= valor; i++)
        {
            Console.WriteLine($"{i} {Math.Pow(i, 2)} {Math.Pow(i, 3)}");
        }
    }
}
