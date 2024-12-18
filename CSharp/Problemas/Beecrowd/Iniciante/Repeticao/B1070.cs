using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1070 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Seis Números Ímpares");

        int x = int.Parse(Console.ReadLine());
        int numeroAtual = x;
        int contadorImpares = 0;

        while (contadorImpares < 6)
        {
            if (numeroAtual % 2 != 0)
            {
                Console.WriteLine(numeroAtual);
                contadorImpares++;
            }

            numeroAtual++;
        }
    }
}
