using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Vetores;

internal class B1173 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Preenchimento de Vetor I");

        int numero = int.Parse(Console.ReadLine());

        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine($"N[{i}] = {numero}");
            numero *= 2;
        }
    }
}
