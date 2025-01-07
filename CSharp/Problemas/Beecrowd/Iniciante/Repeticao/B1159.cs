using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;

internal class B1159 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Soma de Pares Consecutivos");

        int numero;

        while ((numero = int.Parse(Console.ReadLine())) != 0)
        {
            int quantidadeDePares = 0;
            int somatorio = 0;

            while (quantidadeDePares < 5)
            {
                if (numero % 2 == 0)
                {
                    somatorio += numero;
                    quantidadeDePares++;
                }

                numero++;
            }

            Console.WriteLine(somatorio);
        }
    }
}
