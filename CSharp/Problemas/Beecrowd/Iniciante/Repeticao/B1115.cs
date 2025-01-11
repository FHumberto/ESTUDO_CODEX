using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1115 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Quadrante");

        while (true)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int x = int.Parse(valores[0]);
            int y = int.Parse(valores[1]);

            if (x == 0 || y == 0)
                break;

            if (x > 0 && y > 0)
                Console.WriteLine("primeiro");
            if (x < 0 && y > 0)
                Console.WriteLine("segundo");
            if (x < 0 && y < 0)
                Console.WriteLine("terceiro");
            if (x > 0 && y < 0)
                Console.WriteLine("quarto");
        }
    }
}
