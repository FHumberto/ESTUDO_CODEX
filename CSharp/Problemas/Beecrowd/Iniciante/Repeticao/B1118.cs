using System.Globalization;

using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1118 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Várias Notas com Validação");

        int codigo = 0;

        do
        {
            int qtd = 0;
            float notas = 0;

            while (qtd != 2)
            {
                float nota = float.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (nota < 0 || nota > 10)
                {
                    Console.WriteLine("nota invalida");
                }
                else
                {
                    notas += nota;
                    qtd++;
                }
            }

            float media = notas / 2;

            Console.WriteLine($"media = {media.ToString("F2", CultureInfo.InvariantCulture)}");

            while (true)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                codigo = int.Parse(Console.ReadLine());

                if (codigo == 1 || codigo == 2)
                {
                    break;
                }
            }

        } while (codigo != 2);
    }
}
