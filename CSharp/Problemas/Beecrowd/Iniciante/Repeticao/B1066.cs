using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1066 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Pares, Ímpares, Positivos e Negativos");

        const int Par = 0;
        const int Impar = 1;
        const int Positivo = 2;
        const int Negativo = 3;

        int[] valores = new int[4];

        for (int i = 0; i < 5; i++)
        {
            int numero = int.Parse(Console.ReadLine());

            valores[numero % 2 == 0 ? Par : Impar]++;
            if (numero > 0)
            {
                valores[Positivo]++;
            }
            else if (numero < 0)
            {
                valores[Negativo]++;
            }
        }

        Console.WriteLine($"{valores[Par]} valor(es) par(es)");
        Console.WriteLine($"{valores[Impar]} valor(es) impar(es)");
        Console.WriteLine($"{valores[Positivo]} valor(es) positivo(s)");
        Console.WriteLine($"{valores[Negativo]} valor(es) negativo(s)");
    }
}
