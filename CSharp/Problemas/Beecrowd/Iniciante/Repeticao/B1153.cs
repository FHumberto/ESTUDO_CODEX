using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1153 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Fatorial Simples");

        int numero = int.Parse(Console.ReadLine());
        int resultado = 0;

        if (numero == 0 || numero == 1)
        {
            resultado = 1;
        }
        else
        {
            resultado = 1;

            for (int i = numero; i >= 1; i--)
            {
                resultado *= i;
            }
        }

        Console.WriteLine(resultado);
    }
}
