using Beecrowd.Template;
using Beecrowd.Util;

namespace Beecrowd.Iniciante.Repeticao;
internal class B1158 : Problema
{
    public override void PMain()
    {
        ProcedureHelpers.Cabecalho("Soma de Ímpares Consecutivos III");

        int casos = int.Parse(Console.ReadLine());

        for (int i = 0; i < casos; i++)
        {
            string[] linha = Console.ReadLine().Split(' ');
            int valor = int.Parse(linha[0]);
            int imparesConsecutivos = int.Parse(linha[1]);
            int quantidadeImpares = 0;
            int somatorio = 0;

            while (quantidadeImpares < imparesConsecutivos)
            {
                if (valor % 2 != 0)
                {
                    somatorio += valor;
                    quantidadeImpares++;
                }

                valor++;
            }

            Console.WriteLine(somatorio);
        }
    }
}
