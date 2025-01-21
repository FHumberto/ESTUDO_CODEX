using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1117 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Validação de Nota");

        float notas = 0f;
        int aux = 0;

        while (aux < 2)
        {
            float nota = float.Parse(Console.ReadLine(), System.Globalization.CultureInfo.InvariantCulture);

            if (nota >= 0 && nota <= 10)
            {
                notas += nota;
                aux++;
            }
            else
            {
                Console.WriteLine("nota invalida");
            }
        }

        Console.WriteLine($"media = {(notas / 2).ToString("F2", System.Globalization.CultureInfo.InvariantCulture)}");
    }
}
